using Application.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Person person)
        {
            await Task.Run(() =>
            {
                _context.People.AddAsync(person);
                _context.SaveChangesAsync();
            });
        }

        public async Task DeleteAsync(int personId)
        {
            Person person = await _context.People.FirstOrDefaultAsync(x => x.PersonId == personId);
            await Task.Run(() =>
            {
                _context.People.Remove(person);
                _context.SaveChangesAsync();
            });
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<Person> GetAsync(int personId)
        {
            return await _context.People.FirstOrDefaultAsync(x => x.PersonId == personId);
        }

        public async Task UpdateAsync(Person person)
        {
            await Task.Run(() =>
            {
                _context.People.Update(person);
            });
        }
    }
}
