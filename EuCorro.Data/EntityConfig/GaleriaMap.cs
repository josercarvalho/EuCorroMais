using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class GaleriaMap : EntityTypeConfiguration<Galeria>
    {
        public GaleriaMap()
        {
            // Primary Key
            this.HasKey(t => t.GaleriaId);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(150);           

            this.Property(t => t.Pasta)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Galeria");
            this.Property(t => t.GaleriaId).HasColumnName("GaleriaId");
            this.Property(t => t.EventoId).HasColumnName("EventoId");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Pasta).HasColumnName("Pasta");

            // Relationships
            this.HasRequired(t => t.Evento)
                .WithMany(t => t.Galerias)
                .HasForeignKey(d => d.EventoId);

        }
    }
}
