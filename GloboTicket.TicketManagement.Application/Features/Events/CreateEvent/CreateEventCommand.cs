using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.CreateEvent
{
    public class CreateEventCommand : IRequest<Event>
    {
        public object Name { get; internal set; }
    }
}
