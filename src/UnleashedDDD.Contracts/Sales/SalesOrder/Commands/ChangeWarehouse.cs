using System;

namespace UnleashedDDD.Contracts.Sales.SalesOrder.Commands
{
    public class ChangeWarehouse
    {
        public Guid WarehouseId { get; private set; }

        public ChangeWarehouse(Guid warehouseId)
        {
            WarehouseId = warehouseId;
        }

    }
}
