using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Data
{
    public class ContextTest : DbContext
    {
        public ContextTest(DbContextOptions<ContextTest> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
