using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.Esercitazione.Master.Core.Entities;

namespace Week7.Esercitazione.Master.RepositoryEF.Configurations
{
    internal class ProdottoConfiguration : IEntityTypeConfiguration<Prodotto>
    {
        public void Configure(EntityTypeBuilder<Prodotto> modelBuilder)
        {
            modelBuilder.ToTable("Prodotto");
            modelBuilder.HasKey(p => p.IdProd);
            modelBuilder.Property(p => p.Descrizione).IsRequired();
            modelBuilder.Property(p => p.PrezzoFornitore).IsRequired();
            modelBuilder.Property(p => p.PrezzoPubblico).IsRequired();

        }
    }
}
