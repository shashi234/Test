using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CalculatorDemo.Models
{
    public class DBCalculationsContext : DbContext
    {
        public DBCalculationsContext(DbContextOptions<DBCalculationsContext> options)
            : base(options)
        {
        }

        public DbSet<CalculatorDemo.Models.Calculator>? Calculations { get; set; }
    }
}