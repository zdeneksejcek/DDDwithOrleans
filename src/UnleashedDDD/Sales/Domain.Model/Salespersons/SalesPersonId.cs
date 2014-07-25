using System;

namespace UnleashedDDD.Sales.Domain.Model.Salespersons
{
    public class SalespersonId
    {
        public Guid Id { get; private set; }

        public SalespersonId(Guid id)
        {
            Id = id;
        }
    }
}
