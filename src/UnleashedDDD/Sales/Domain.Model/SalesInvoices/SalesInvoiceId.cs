using System;

namespace UnleashedDDD.Sales.Domain.Model.SalesInvoices
{
    public class SalesInvoiceId
    {
        public Guid Id { get; private set; }

        public SalesInvoiceId(Guid id)
        {
            Id = id;
        }
    }
}
