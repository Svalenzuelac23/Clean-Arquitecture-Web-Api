using Application.CQRS.Query.DTOs;
using Application.Repositories;
using Application.Wrappers;
using AutoMapper;
using System.Threading.Tasks;

namespace Application.CQRS.Query.Queries
{
    public class PersonQueryService : IPersonQueryService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonQueryService(
            IPersonRepository personRepository
            , IMapper mapper
            )
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<Response<PersonDTO>> GetAsync(int personId)
        {
            PersonDTO person = _mapper.Map<PersonDTO>(await _personRepository.GetAsync(personId));

            return new Response<PersonDTO>
            {
                Data = person
            };
        }
    }
}
