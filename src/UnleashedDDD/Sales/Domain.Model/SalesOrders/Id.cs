using System;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrders
{
    public class SalesOrderId
    {
        public Guid Id { get; private set; }

        public SalesOrderId(Guid id)
        {
            Id = id;
        }
    }
}