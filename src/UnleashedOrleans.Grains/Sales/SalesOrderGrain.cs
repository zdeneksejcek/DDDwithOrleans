using System.Threading.Tasks;
using UnleashedDDD;
using UnleashedDDD.Contracts.Sales.SalesOrder.Commands;
using UnleashedDDD.Sales.Domain.Model;
using UnleashedDDD.Sales.Domain.Model.Customers;
using UnleashedDDD.Sales.Domain.Model.SalesOrders;
using UnleashedDDD.Sales.Domain.Model.SalesOrders.State;
using UnleashedDDD.Sales.Domain.Model.Salespersons;
using UnleashedOrleans.Interfaces.Sales;

namespace UnleashedOrleans.Grains.Sales
{
    public class SalesOrderGrain : AggregateGrainBase<SalesOrder,SalesOrderState>, ISalesOrderGrain
    {
        public Task Execute(CreateNewSalesOrder c)
        {
            return CreateAggregate(
                observer => new SalesOrder(
                    observer,
                    new CustomerId(c.CustomerId),
                    new RefWarehouseId(c.WarehouseId)));
        }

        public Task Execute(AddLine c)
        {
            return ProcessChange(
                order => order.Lines.Add(
                    new ProductId(c.ProductId),
                    new Quantity(c.Quantity),
                    new UnitPrice(c.Price.Amount, new Currency(c.Price.Currency)),
                    new SalesTax(c.Tax.Id, c.Tax.Rate)));
        }

        public Task Execute(RemoveLine c)
        {
            return ProcessChange(
                order => order.Lines.Remove(
                    new LineId(c.LineId)));
        }

        public Task Execute(ChangeSalesTax c)
        {
            return ProcessChange(
                order => order.ChangeTax(
                    new SalesTax(c.TaxId, c.Rate)));
        }

        public Task Execute(ChangeWarehouse c)
        {
            return ProcessChange(
                order => order.ChangeWarehouse(
                    new RefWarehouseId(c.WarehouseId)));
        }

        public Task Execute(ChangeSalesperson c)
        {
            return ProcessChange(
                order => order.ChangeSalesPerson(
                    new SalespersonId(c.SalespersonId)));
        }

        public Task Execute(CompleteSalesOrder c)
        {
            return ProcessChange(
                order => order.Complete());
        }

        protected override SalesOrder ReinstantiateAggregate(SalesOrderState state, IDomainEventRaiser observer)
        {
            return new SalesOrder(observer, state);
        }
    }
}