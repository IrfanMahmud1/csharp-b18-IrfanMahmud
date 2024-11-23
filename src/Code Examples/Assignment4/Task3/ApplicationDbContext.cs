using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString = "Server=.;Database=CSharpB18;User ID=csharpb18;Password=123456;Trust Server Certificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}
