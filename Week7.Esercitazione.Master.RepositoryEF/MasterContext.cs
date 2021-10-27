using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.Esercitazione.Master.Core.Entities;
using Week7.Esercitazione.Master.RepositoryEF.Configurations;

namespace Week7.Esercitazione.Master
{
    public class MasterContext : DbContext
    {
        public DbSet<Prodotto> Prodotti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Amazon; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Prodotto>(new ProdottoConfiguration());
        }
    }
}