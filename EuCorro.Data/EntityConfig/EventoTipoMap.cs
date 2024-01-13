using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class EventoTipoMap : EntityTypeConfiguration<EventoTipo>
    {
        public EventoTipoMap()
        {
            // Primary Key
            this.HasKey(t => t.EventoTipoId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("EventoTipo");
            this.Property(t => t.EventoTipoId).HasColumnName("EventoTipoId");
            this.Property(t => t.Nome).HasColumnName("Nome");

            // Relationships
        }
    }
}
