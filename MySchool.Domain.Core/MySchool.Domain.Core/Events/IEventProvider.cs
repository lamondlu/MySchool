using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.Domain.Core.Events
{
    public interface IEventProvider
    {
        void LoadsFromHistory(IEnumerable<DomainEvent> history);

        IEnumerable<DomainEvent> GetUncommittedChanges();
    }
}
