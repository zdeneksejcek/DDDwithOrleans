using System;

namespace UnleashedDDD.Sales.Domain.Model
{
    public class RefWarehouseId
    {
        public Guid Id { get; private set; }

        public RefWarehouseId(Guid id)
        {
            Id = id;
        }
    }
}