using System;

namespace UnleashedDDD.Sales.Domain.Model
{
    public class ProductId
    {
        public Guid Id { get; private set; }

        public ProductId(Guid id)
        {
            Id = id;
        }
    }
}