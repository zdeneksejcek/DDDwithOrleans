using System;

namespace UnleashedDDD.Commands.Sales.SalesOrder
{
    public class AddLine
    {
        public Guid SalesOrderId { get; private set; }

        public Guid ProductId { get; private set; }

        public decimal Quantity { get; private set; }

        public Price Price { get; private set; }

        public Tax Tax { get; private set; }

        public AddLine(Guid salesOrderId, Guid productId, decimal quantity, Price price, Tax tax)
        {
            SalesOrderId = salesOrderId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            Tax = tax;
        }
    }
}