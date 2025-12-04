using AutodjaOmanikud.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AutodjaOmanikud
{
    public class ToodedContext : DbContext
    {
        public DbSet<Toodetabel> Toodetabel { get; set; }
        public DbSet<Kategooriatabel> Kategooriatabel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tooded.db");
        }
    }
}
