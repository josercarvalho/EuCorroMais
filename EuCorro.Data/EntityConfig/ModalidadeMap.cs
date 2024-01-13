using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class ModalidadeMap : EntityTypeConfiguration<Modalidade>
    {
        public ModalidadeMap()
        {
            // Primary Key
            this.HasKey(t => t.ModalidadeId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Modalidade");
            this.Property(t => t.ModalidadeId).HasColumnName("ModalidadeId");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Distancia).HasColumnName("Distancia");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            this.Property(t => t.CategoriaId).HasColumnName("CategoriaId");

            // Relationships
            this.HasOptional(t => t.Categoria)
                .WithMany()
                .HasForeignKey(d => d.CategoriaId);
        }
    }
}
