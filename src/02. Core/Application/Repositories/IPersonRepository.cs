using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IPersonRepository
    {
        Task AddAsync(Person person);
        Task UpdateAsync(Person person);
        Task DeleteAsync(int personId);
        Task<Person> GetAsync(int personId);
        Task<List<Person>> GetAllAsync();
    }
}
