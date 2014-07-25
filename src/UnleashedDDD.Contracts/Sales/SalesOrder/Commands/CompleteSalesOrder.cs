using System;

namespace UnleashedDDD.Contracts.Sales.SalesOrder.Commands
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
