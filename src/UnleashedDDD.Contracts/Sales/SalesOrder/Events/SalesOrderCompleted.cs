using System;

namespace UnleashedDDD.Contracts.Sales.SalesOrder.Events
{
    public class SalesOrderCompleted
    {
        public Guid SalesOrderId { get; private set; }

        public SalesOrderCompleted(Guid salesOrderId)
        {
            SalesOrderId = salesOrderId;
        }
    }
}