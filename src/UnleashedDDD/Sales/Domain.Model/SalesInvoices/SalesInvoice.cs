using UnleashedDDD.Sales.Domain.Model.SalesInvoices.State;

namespace UnleashedDDD.Sales.Domain.Model.SalesInvoices
{
    public class SalesInvoice : IStatable<SalesInvoiceState>
    {
        public SalesInvoiceState GetState()
        {
            throw new System.NotImplementedException();
        }
    }
}