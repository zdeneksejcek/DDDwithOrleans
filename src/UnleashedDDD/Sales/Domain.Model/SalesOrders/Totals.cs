using System.Linq;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrders
{
    public class Totals
    {
        public MonetaryValue SubTotal { get; private set; }

        public MonetaryValue TaxTotal { get; private set; }

        public MonetaryValue Total { get; private set; }

        internal Totals(Lines lines)
        {
            SubTotal = CalculateSubTotal(lines);
            TaxTotal = CalculateTaxTotal(lines);
            Total = SubTotal + TaxTotal;
        }

        private static MonetaryValue CalculateSubTotal(Lines lines)
        {
            var amount = lines.Sum(p => p.LineTotal.Amount);

            return new MonetaryValue(amount, lines.GetSalesOrderCurrency());
        }

        private static MonetaryValue CalculateTaxTotal(Lines lines)
        {
            var amount = lines.Sum(p =>p.LineTax.Amount);

            return new MonetaryValue(amount, lines.GetSalesOrderCurrency());
        }
    }
}