using System;

namespace UnleashedDDD.Contracts.Sales.SalesOrder.Commands
{
    public class ChangeSalesperson
    {
        public Guid SalespersonId { get; private set; }

        public ChangeSalesperson(Guid salespersonId)
        {
            SalespersonId = salespersonId;
        }
    }
}
