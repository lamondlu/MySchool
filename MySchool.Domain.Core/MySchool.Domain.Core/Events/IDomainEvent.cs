using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.Domain.Core.Events
{
    public interface IDomainEvent
    {
        string EventKey { get; }

        DateTime OccurredOn { get; }

        Guid CommandUniqueId { get; set; }
    }
}
