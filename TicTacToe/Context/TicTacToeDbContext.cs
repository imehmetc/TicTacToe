using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Enitities;

namespace TicTacToe.Context
{
    public class TicTacToeDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = IMEHMETC;Database = TicTacToeDb;User Id = sa;Password = 123;TrustServerCertificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasIndex(p => p.UserName).IsUnique();
        }
    }
}
