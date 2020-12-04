using Application.CQRS.Query.DTOs;
using Application.Wrappers;
using System.Threading.Tasks;

namespace Application.CQRS.Query.Queries
{
    public interface IPersonQueryService
    {
        Task<Response<PersonDTO>> GetAsync(int personId);
    }
}
