using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.CidadeId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Cidade");
            this.Property(t => t.CidadeId).HasColumnName("CidadeId");
            this.Property(t => t.EstadoId).HasColumnName("EstadoId");
            this.Property(t => t.Nome).HasColumnName("Nome");

            // Relationships
            this.HasRequired(t => t.Estado)
                .WithMany(t => t.Cidades)
                .HasForeignKey(d => d.EstadoId);

        }
    }
}
