using System;

namespace UnleashedDDD.Commands
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
