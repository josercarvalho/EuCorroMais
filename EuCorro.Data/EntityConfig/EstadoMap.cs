using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class EstadoMap : EntityTypeConfiguration<Estado>
    {
        public EstadoMap()
        {
            // Primary Key
            this.HasKey(t => t.EstadoId);

            // Properties
            this.Property(t => t.Sigla)
                .HasMaxLength(100);

            this.Property(t => t.Nome)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Estado");
            this.Property(t => t.EstadoId).HasColumnName("EstadoId");
            this.Property(t => t.PaisId).HasColumnName("PaisId");
            this.Property(t => t.Sigla).HasColumnName("Sigla");
            this.Property(t => t.Nome).HasColumnName("Nome");

            // Relationships
            this.HasRequired(t => t.Pais)
                .WithMany(t => t.Estados)
                .HasForeignKey(d => d.PaisId);    
        }
    }
}
