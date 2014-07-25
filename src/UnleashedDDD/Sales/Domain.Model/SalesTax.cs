using System;

namespace UnleashedDDD.Sales.Domain.Model
{
    public class SalesTax
    {
        public Guid Id { get; private set; }

        public decimal Rate { get; private set; }

        public SalesTax(Guid taxId, decimal rate)
        {
            Id = taxId;
            Rate = rate;
        }
    }
}