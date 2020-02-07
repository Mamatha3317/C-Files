using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmplopyeeDataMAnagement.Models;

namespace EmplopyeeDataMAnagement.Data
{
    public class EmplopyeeDataMAnagementContext : DbContext
    {
        public EmplopyeeDataMAnagementContext (DbContextOptions<EmplopyeeDataMAnagementContext> options)
            : base(options)
        {
        }

        public DbSet<EmplopyeeDataMAnagement.Models.Employee> Employee { get; set; }
    }
}
