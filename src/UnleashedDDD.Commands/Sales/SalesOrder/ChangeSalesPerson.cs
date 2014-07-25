using System;

namespace UnleashedDDD.Commands.Sales.SalesOrder
{
    public class ChangeSalesPerson
    {
        public Guid SalesPersonId { get; private set; }

        public ChangeSalesPerson(Guid salesPersonId)
        {
            SalesPersonId = salesPersonId;
        }
    }
}
