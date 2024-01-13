using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class NumeroDoPeitoMap : EntityTypeConfiguration<NumeroDoPeito>
    {
        public NumeroDoPeitoMap()
        {
            // Primary Key
            this.HasKey(t => t.NumeroDoPeitoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("NumeroDoPeito");
            this.Property(t => t.NumeroDoPeitoId).HasColumnName("NumeroDoPeitoId");
            this.Property(t => t.EventoId).HasColumnName("EventoId");
            this.Property(t => t.ModalidadeEventoId).HasColumnName("ModalidadeEventoId");
            this.Property(t => t.NumeroIni).HasColumnName("NumeroIni");
            this.Property(t => t.NumeroFin).HasColumnName("NumeroFin");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.NumeroAtual).HasColumnName("NumeroAtual");
            this.Property(t => t.TipoNumeracao).HasColumnName("TipoNumeracao");

            // Relationships
            this.HasRequired(t => t.Evento)
                .WithMany(t => t.NumeroDoPeito)
                .HasForeignKey(d => d.EventoId);
            this.HasRequired(t => t.ModalidadeEvento)
                .WithMany(t => t.NumeroDoPeito)
                .HasForeignKey(d => d.ModalidadeEventoId);
        }
    }
}
