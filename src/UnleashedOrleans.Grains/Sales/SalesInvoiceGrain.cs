using UnleashedDDD.Sales.Domain.Model.SalesInvoices;
using UnleashedOrleans.Interfaces.Sales;

namespace UnleashedOrleans.Grains.Sales
{
    public class SalesInvoiceGrain : AggregateGrainBase<SalesInvoice, ISalesInvoiceGrainState>, ISalesInvoiceGrain
    {
        protected override SalesInvoice ReinstantiateAggregate(ISalesInvoiceGrainState state, UnleashedDDD.IDomainEventRaiser observer)
        {
            throw new System.NotImplementedException();
        }
    }
}