using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employees__information.Models;

namespace Employees__information.Data
{
    public class Employees__informationContext : DbContext
    {
        public Employees__informationContext (DbContextOptions<Employees__informationContext> options)
            : base(options)
        {
        }

        public DbSet<Employees__information.Models.Department> Department { get; set; }

        public DbSet<Employees__information.Models.Employee> Employee { get; set; }
    }
}
