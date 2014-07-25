using System;

namespace UnleashedDDD.Contracts
{
    public abstract class AuditableCommand
    {
        public Guid UserId { get; private set; }

        public AuditableCommand(Guid userId)
        {
            UserId = userId;
        }
    }
}
