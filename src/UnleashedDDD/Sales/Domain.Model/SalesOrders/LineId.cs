using System;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrders
{
    public class LineId
    {
        public Guid Id { get; private set; }

        public LineId(Guid id)
        {
            Id = id;
        }
    }
}