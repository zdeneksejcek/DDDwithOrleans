using System;

namespace UnleashedDDD.Sales.Domain.Model.Customers
{
    public class CustomerId
    {
        public Guid Id { get; private set; }

        public CustomerId(Guid id)
        {
            Id = id;
        }
    }
}
