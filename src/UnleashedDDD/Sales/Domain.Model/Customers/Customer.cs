using UnleashedDDD.Sales.Domain.Model.Customers.State;

namespace UnleashedDDD.Sales.Domain.Model.Customers
{
    public class Customer : IStatable<CustomerState>
    {
        public CustomerId Id { get; private set; }

        public CustomerState GetState()
        {
            throw new System.NotImplementedException();
        }
    }
}