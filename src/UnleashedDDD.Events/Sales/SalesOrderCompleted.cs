using System;

namespace UnleashedDDD.Events.Sales
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