using System.Threading.Tasks;
using UnleashedDDD.Contracts.Sales.SalesOrder.Commands;

namespace UnleashedOrleans.Interfaces.Sales
{
    public interface ISalesOrderGrain : Orleans.IGrain
    {
        Task Execute(CreateNewSalesOrder command);

        Task Execute(AddLine c);

        Task Execute(RemoveLine c);

        Task Execute(ChangeSalesTax c);

        Task Execute(ChangeSalesperson c);

        Task Execute(ChangeWarehouse c);

        Task Execute(CompleteSalesOrder c);
    }
}