using EuCorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class DependentesMap : EntityTypeConfiguration<Dependentes>
    {
        public DependentesMap()
        {
            // Primary Key
            HasKey(t => t.DependenteId);
            
            // Properties
            // Table & Column Mappings
            ToTable("Dependentes");
            Property(t => t.DependenteId).HasColumnName("DependenteId");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.Nome).HasColumnName("Nome");
            Property(t => t.DataNascimento).HasColumnName("DataNascimento");
            Property(t => t.Documento).HasColumnName("Documento");
            Property(t => t.Telefone).HasColumnName("Telefone");
            Property(t => t.Sexo).HasColumnName("Sexo");
            Property(t => t.Contato).HasColumnName("Contato");
            Property(t => t.FoneContato).HasColumnName("FoneContato");

            // Relationships
            HasRequired(t => t.Usuario)
                .WithMany(t => t.Dependentes)
                .HasForeignKey(d => d.UserId);
        }
    }
}
