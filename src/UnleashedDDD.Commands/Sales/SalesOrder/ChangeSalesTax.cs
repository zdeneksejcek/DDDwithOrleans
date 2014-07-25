using System;

namespace UnleashedDDD.Commands.Sales.SalesOrder
{
    public class ChangeSalesTax
    {
        public Guid TaxId { get; private set; }

        public decimal Rate { get; private set; }

        public ChangeSalesTax(Guid taxId, decimal rate)
        {
            TaxId = taxId;
            Rate = rate;
        }

    }
}
