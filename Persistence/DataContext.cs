using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext  
    {
        public DataContext(DbContextOptions options):base(options) { }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Value>()
            .HasData(
                new Value {Id = 1, Name = "Sri Annai Saranam 1"},
                new Value {Id = 2, Name = "Sri Annai Saranam 2"},
                new Value {Id = 3, Name = "Sri Annai Saranam 3"}
            );
        }
    }
}
