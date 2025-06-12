using Microsoft.EntityFrameworkCore;
using Inversiones_moronta.models;
using System.Collections.Generic;

namespace Inversiones_moronta.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Inversion> Inversiones { get; set; }
    }
}

