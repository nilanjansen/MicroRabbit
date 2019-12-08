using MediatR;
using MicroRabbit.Banking.Domain.Commnad;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandlers : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;
        public TransferCommandHandlers(IEventBus bus)
        {
            _bus = bus;
        }
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //public event to Rabbit MQ
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult(true);
        }
    }
}
