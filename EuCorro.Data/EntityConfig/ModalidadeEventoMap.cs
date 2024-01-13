using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class ModalidadeEventoMap : EntityTypeConfiguration<ModalidadeEvento>
    {
        public ModalidadeEventoMap()
        {
            // Primary Key
            this.HasKey(t => t.ModalidadeEventoId);

            this.Property(t => t.Percurso)
                .HasMaxLength(8000);

            this.Property(t => t.PercursoImg)
                .HasMaxLength(100);

            // Properties
            // Table & Column Mappings
            this.ToTable("ModalidadeEvento");
            this.Property(t => t.ModalidadeEventoId).HasColumnName("ModalidadeEventoId");
            this.Property(t => t.EventoId).HasColumnName("EventoId");
            this.Property(t => t.CategoriaId).HasColumnName("CategoriaId");
            this.Property(t => t.Reverzamento).HasColumnName("Reverzamento");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            this.Property(t => t.Vagas).HasColumnName("Vagas");
            this.Property(t => t.NumeroInicial).HasColumnName("NumeroInicial");
            this.Property(t => t.NumeroFinal).HasColumnName("NumeroFinal");
            this.Property(t => t.IdadeMin).HasColumnName("IdadeMin");
            this.Property(t => t.IdadeMax).HasColumnName("IdadeMax");
            this.Property(t => t.Percurso).HasColumnName("Percurso");
            this.Property(t => t.PercursoImg).HasColumnName("PercursoImg");

            // Relationships
            this.HasRequired(t => t.Evento)
                .WithMany(t => t.ModalidadeEventos)
                .HasForeignKey(d => d.EventoId);   
            this.HasRequired(t => t.Categoria)
                .WithMany(t => t.ModalidadeEventos)
                .HasForeignKey(d => d.CategoriaId);
        }
    }
}
