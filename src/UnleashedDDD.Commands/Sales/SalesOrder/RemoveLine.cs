using System;

namespace UnleashedDDD.Commands.Sales.SalesOrder
{
    public class RemoveLine
    {
        public Guid SalesOrderId { get; private set; }

        public Guid LineId { get; private set; }

        public RemoveLine(Guid salesOrderId, Guid lineId)
        {
            SalesOrderId = salesOrderId;
            LineId = lineId;
        }

    }
}