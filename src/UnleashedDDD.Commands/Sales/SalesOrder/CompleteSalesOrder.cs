using System;

namespace UnleashedDDD.Commands.Sales.SalesOrder
{
    public class CompleteSalesOrder
    {
        public Guid SalesOrderId { get; private set; }

        public CompleteSalesOrder(Guid salesOrderId)
        {
            SalesOrderId = salesOrderId;
        }
    }
}
