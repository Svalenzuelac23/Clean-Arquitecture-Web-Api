using Application.CQRS.Command.Commands;
using AutoMapper;
using Domain.Models;

namespace Infraestructure.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Person, PersonCreateCommand>().ReverseMap();            
        }
    }
}
