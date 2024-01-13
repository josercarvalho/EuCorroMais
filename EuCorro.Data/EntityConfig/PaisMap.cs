using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class PaisMap : EntityTypeConfiguration<Pais>
    {
        public PaisMap()
        {
            // Primary Key
            this.HasKey(t => t.PaisId);

            // Properties
            this.Property(t => t.Sigla)
                .HasMaxLength(100);

            this.Property(t => t.Nome)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Pais");
            this.Property(t => t.PaisId).HasColumnName("PaisId");
            this.Property(t => t.Sigla).HasColumnName("Sigla");
            this.Property(t => t.Nome).HasColumnName("Nome");
        }
    }
}
