using BugTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class BugsContext : DbContext
    {
        public BugsContext(DbContextOptions<BugsContext> options) : base(options) { }

        public DbSet<Bug> Bugs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .,5433; Database = Default; User Id = sa; Password = Passw0rd;");
        }
    }
}
