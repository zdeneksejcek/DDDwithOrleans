using System;

namespace UnleashedDDD.Contracts
{
    public class AuditableEvent
    {
        public object Event { get; private set; }
        public Guid UserId { get; private set; }


        public AuditableEvent(object @event, Guid userId)
        {
            UserId = userId;
            this.Event = @event;
        }

    }
}