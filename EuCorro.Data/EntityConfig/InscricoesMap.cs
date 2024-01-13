using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class InscricoesMap : EntityTypeConfiguration<Inscricoes>
    {
        public InscricoesMap()
        {
            // Primary Key
            HasKey(t => t.InscricoesId);

            // Properties
            // Table & Column Mappings
            ToTable("Inscricoes");
            Property(t => t.InscricoesId).HasColumnName("InscricoesId");
            Property(t => t.EventoId).HasColumnName("EventoId");
            Property(t => t.UserId).HasColumnName("UserId");
            Property(t => t.ModalidadeEventoId).HasColumnName("ModalidadeEventoId");
            //Property(t => t.Camiseta).HasColumnName("Camiseta");
            Property(t => t.Valor).HasColumnName("Valor");
            //Property(t => t.Numero).HasColumnName("Numero");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.DataCadastro).HasColumnName("DataCadastro");

            // Relationships
            HasRequired(t => t.Evento)
                .WithMany(t => t.Inscricoes)
                .HasForeignKey(d => d.EventoId);
            HasRequired(t => t.ModalidadeEvento)
                .WithMany(t => t.Inscricoes)
                .HasForeignKey(d => d.ModalidadeEventoId);
            HasRequired(t => t.Usuario)
                .WithMany(t => t.Inscricoes)
                .HasForeignKey(d => d.UserId);

        }
    }
}
