using Application.CQRS.Command.Commands;
using Application.Repositories;
using AutoMapper;
using Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CQRS.Command.EventHandlers
{
    public class PersonCreateEventHandler : INotificationHandler<PersonCreateCommand>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonCreateEventHandler(
            IPersonRepository personRepository
            ,IMapper mapper
            )
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task Handle(PersonCreateCommand notification, CancellationToken cancellationToken)
        {            
            await _personRepository.AddAsync(_mapper.Map<Person>(notification));
        }
    }
}
