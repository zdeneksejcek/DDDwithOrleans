using System;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrders
{
    public class Line
    {
        public SalesOrderId SalesOrder { get; private set; }

        public LineId Id { get; private set; }

        public ProductId Product { get; private set; }

        public Quantity Quantity { get; set; }

        public UnitPrice Price { get; set; }

        public Comment Comment { get; set; }

        public SalesTax Tax { get; set; }

        public MonetaryValue LineTax
        {
            get
            {
                return new MonetaryValue(LineTotal.Amount * Tax.Rate, Price.Currency);
            }
        }

        public MonetaryValue LineTotal
        {
            get
            {
                return new MonetaryValue(Price.Amount * Quantity.Value, Price.Currency);
            }
        }

        public LineStatus Status { get; set; }

        internal Line(SalesOrderId salesOrder, ProductId product, Quantity quantity, UnitPrice price, SalesTax tax)
        {
            Id = new LineId(Guid.NewGuid());
            SalesOrder = salesOrder;
            Quantity = quantity;
            Product = product;
            Price = price;
            Tax = tax;
        }
    }
}