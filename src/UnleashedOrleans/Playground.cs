using System;
using UnleashedOrleans.Interfaces.Sales;

namespace UnleashedOrleans
{
    public class Playground
    {
        public void Run()
        {
            var soGrain = SalesOrderGrainFactory.GetGrain(Guid.NewGuid());
        }
    }
}