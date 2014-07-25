using System;
using System.Threading.Tasks;
using Orleans;
using UnleashedDDD;
using UnleashedDDD.Sales.Domain.Model;

namespace UnleashedOrleans.Grains
{
    public abstract class AggregateGrainBase<TAggregate,TState> : GrainBase<IAggregateRootState<TState>> where TAggregate : IStatable
    {
        private TAggregate Aggregate { get; set; }

        private Task Persist()
        {
            return base.State.WriteStateAsync();
        }

        private void AssureAggregateExists()
        {
            if (Aggregate == null)
                throw new Exception("Aggregate does not exist");
        }

        public override async Task ActivateAsync()
        {
            await base.ActivateAsync();

            if (State != null && State.Value != null)
                Aggregate = ReinstantiateAggregate(State.Value, this.Observer);
        }

        private IDomainEventRaiser Observer { get; set; }

        protected abstract TAggregate ReinstantiateAggregate(TState state, IDomainEventRaiser observer);

        protected Task ProcessChange(Action<TAggregate> commandFunc)
        {
            AssureAggregateExists();

            commandFunc.Invoke(Aggregate);
            base.State.Value = (TState)Aggregate.GetState();

            return Persist();
        }

        protected Task CreateAggregate(Func<IDomainEventRaiser, TAggregate> commandFunc)
        {
            this.Aggregate = commandFunc.Invoke(this.Observer);
            base.State.Value = (TState)Aggregate.GetState();

            return Persist();
        }

    }
}