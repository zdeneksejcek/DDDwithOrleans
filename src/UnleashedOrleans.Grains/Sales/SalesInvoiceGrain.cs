using UnleashedDDD.Sales.Domain.Model.SalesInvoices;
using UnleashedDDD.Sales.Domain.Model.SalesInvoices.State;
using UnleashedOrleans.Interfaces.Sales;

namespace UnleashedOrleans.Grains.Sales
{
    public class SalesInvoiceGrain : AggregateGrainBase<SalesInvoice, SalesInvoiceState>, ISalesInvoiceGrain
    {
        protected override SalesInvoice ReinstantiateAggregate(SalesInvoiceState state, UnleashedDDD.IDomainEventRaiser observer)
        {
            throw new System.NotImplementedException();
        }
    }
}