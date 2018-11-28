using MySchool.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.Domain.Core.Messaging
{
    public interface IEventPublisher : IDisposable
    {
        void Publish<T>(T domainEvent) where T : DomainEvent;
    }
}
