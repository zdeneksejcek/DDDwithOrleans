using Orleans;

namespace UnleashedOrleans.Grains
{
    public interface IAggregateRootState<T> : IGrainState
    {
        T Value { get; set; }
    }
}