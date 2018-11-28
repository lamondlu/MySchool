using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Domain.Core.Events
{
    public interface IEventHandler<TEvent> where TEvent : IDomainEvent
    {
        void Handle(TEvent evt);

        void HandleCore(TEvent evt);

        Task HandleAsync(TEvent evt);
    }
}
