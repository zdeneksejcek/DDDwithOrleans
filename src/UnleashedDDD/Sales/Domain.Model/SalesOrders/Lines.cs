using System.Collections.Generic;
using System.Linq;
using UnleashedDDD.Sales.Domain.Model.SalesOrders.Exceptions;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrders
{
    public class Lines : IEnumerable<Line>
    {
        private readonly List<Line> _lines = new List<Line>();

        private SalesOrderId SalesOrder { get; set; }

        private readonly Status OrderStatus;

        internal Lines(SalesOrderId salesOrder, ref Status orderStatus)
        {
            SalesOrder = salesOrder;
            OrderStatus = orderStatus;
        }

        public Line Get(LineId lineId)
        {
            var line = _lines.FirstOrDefault(p => p.Id.Id == lineId.Id);
            if (line == null)
                throw new LineDoesNotExist();

            return line;
        }

        public void Remove(LineId lineId)
        {
            _lines.RemoveAll(p => p.Id.Id == lineId.Id);
        }

        public Line Add(ProductId product, Quantity quantity, UnitPrice price, SalesTax tax)
        {
            AssureSameLineCurrency(price.Currency);
            OrderStatus.AssureChangeToOrderIsAllowed();

            var line = new Line(SalesOrder, product, quantity, price, tax);
            _lines.Add(line);

            return line;
        }

        private void AssureSameLineCurrency(Currency currency)
        {
            if (GetSalesOrderCurrency() == new Currency("UNK"))
                return;

            if (GetSalesOrderCurrency() != currency)
                throw new MultipleCurrenciesNotSupported(SalesOrder, currency);
        }

        public void AssureAllLinesAllocated()
        {
            var containsUnallocatedLine = _lines.Any(p => p.Status != LineStatus.Allocated);

            if (containsUnallocatedLine)
                throw new OrderContainsUnallocatedLines();
        }

        public void AssureContainsAnyLines()
        {
            if (!_lines.Any())
                throw new NoLine();
        }

        internal Currency GetSalesOrderCurrency()
        {
            var firstLine = _lines.FirstOrDefault();

            return firstLine != null ? firstLine.Price.Currency : new Currency("UNK");
        }

        internal void Remove(Line line)
        {
            OrderStatus.AssureChangeToOrderIsAllowed();

            _lines.Remove(line);
        }

        public IEnumerator<Line> GetEnumerator()
        {
            return _lines.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}