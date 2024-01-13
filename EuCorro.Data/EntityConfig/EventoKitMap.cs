using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class EventoKitMap : EntityTypeConfiguration<EventoKit>
    {
        public EventoKitMap()
        {
            // Primary Key
            this.HasKey(t => t.EventoKitId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(150);

            this.Property(t => t.Descricao)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("EventoKit");
            this.Property(t => t.EventoKitId).HasColumnName("EventoKitId");
            this.Property(t => t.EventoId).HasColumnName("EventoId");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Tamanho_PP).HasColumnName("Tamanho_PP");
            this.Property(t => t.Tamanho_P).HasColumnName("Tamanho_P");
            this.Property(t => t.Tamanho_M).HasColumnName("Tamanho_M");
            this.Property(t => t.Tamanho_G).HasColumnName("Tamanho_G");
            this.Property(t => t.Tamanho_GG).HasColumnName("Tamanho_GG");
            this.Property(t => t.Tamanho_XG).HasColumnName("Tamanho_XG");

            // Relationships
            //HasOptional(t => t.Evento)
            //    .WithMany(t => t.EventoKits)
            //    .HasForeignKey(d => d.EventoId);
        }
    }
}
