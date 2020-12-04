using Domain.Enums;
using MediatR;

namespace Application.CQRS.Command.Commands
{
    public class PersonCreateCommand : INotification
    {        
        public string Name { get; set; }
        public string Age { get; set; }
        public Gender Gender { get; set; }
    }
}
