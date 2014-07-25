namespace UnleashedDDD
{
    public interface IDomainEventRaiser
    {
        void Raise(object @event);
    }
}
