using System;

namespace UnleashedDDD.Commands.Sales.SalesOrder
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
