using System;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrders.Events
{
    public class SalesOrderCompletionStarted
    {
        public Guid SalesOrderId { get; private set; }
        public LineWithProductAndQuantity[] LinesWithProduct { get; private set; }

        public SalesOrderCompletionStarted(Guid salesOrderId, LineWithProductAndQuantity[] linesWithProduct)
        {
            SalesOrderId = salesOrderId;
            LinesWithProduct = linesWithProduct;
        }

        public class LineWithProductAndQuantity
        {
            public Guid Line { get; private set; }
            public Guid Product { get; private set; }

            public decimal Quantity { get; private set; }

            public LineWithProductAndQuantity(Guid line, Guid product, decimal quantity)
            {
                Line = line;
                Product = product;
                Quantity = quantity;
            }
        }


    }
}