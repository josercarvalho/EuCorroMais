using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class PerguntasAdicionaiMap : EntityTypeConfiguration<PerguntasAdicionais>
    {
        public PerguntasAdicionaiMap()
        {
            // Primary Key
            this.HasKey(t => t.PerguntasAdicionaisId);

            // Properties
            this.Property(t => t.TipCampo)
                .HasMaxLength(100);

            this.Property(t => t.Pergunta)
                .HasMaxLength(100);

            this.Property(t => t.TextoAjuda)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("PerguntasAdicionais");
            this.Property(t => t.PerguntasAdicionaisId).HasColumnName("PerguntasAdicionaisId");
            this.Property(t => t.TipCampo).HasColumnName("TipCampo");
            this.Property(t => t.EventoId).HasColumnName("EventoId");
            this.Property(t => t.Obrigatorio).HasColumnName("Obrigatorio");
            this.Property(t => t.Pergunta).HasColumnName("Pergunta");
            this.Property(t => t.TextoAjuda).HasColumnName("TextoAjuda");

            // Relationships
            this.HasRequired(t => t.Evento)
                .WithMany(t => t.PerguntasAdicionais)
                .HasForeignKey(d => d.EventoId);
            this.HasRequired(t => t.ModalidadeEvento)
                .WithMany(t => t.PerguntasAdicionais)
                .HasForeignKey(d => d.ModalidadeEventoId);
        }
    }
}
