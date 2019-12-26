using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestJsonService.Models {

    public class AppDbContext : DbContext {

        public virtual DbSet<System> Systems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context) { }
    }
}
