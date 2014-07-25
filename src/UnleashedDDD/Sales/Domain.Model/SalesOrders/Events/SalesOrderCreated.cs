namespace UnleashedDDD.Sales.Domain.Model.SalesOrders.Events
{
    public class SalesOrderCreated
    {
        public SalesOrderId Id { get; private set; }

        public SalesOrderCreated(SalesOrderId id)
        {
            Id = id;
        }
    }
}