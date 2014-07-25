using System;

namespace UnleashedOrleans.Grains.Sales
{
    public interface ISalesOrderGrainState : Orleans.IGrainState
    {
        Guid OrderId { get; set; }
    }
}
