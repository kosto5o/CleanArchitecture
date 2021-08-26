using System;
using CleanArchitecture.Domain.Core.Events;
using MediatR;

namespace CleanArchitecture.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command(){
            this.Timestamp = DateTime.Now;
        }
    }
}
