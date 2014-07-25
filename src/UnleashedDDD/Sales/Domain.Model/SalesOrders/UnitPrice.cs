namespace UnleashedDDD.Sales.Domain.Model.SalesOrders
{
    public class UnitPrice : MonetaryValue
    {
        public UnitPrice(decimal amount, Currency currency) : base(amount, currency)
        {
            
        }
    }
}