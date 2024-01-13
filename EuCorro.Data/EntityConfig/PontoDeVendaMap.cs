using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class PontoDeVendaMap : EntityTypeConfiguration<PontoDeVendas>
    {
        public PontoDeVendaMap()
        {
            // Primary Key
            this.HasKey(t => t.PontoDeVendasId);

            // Properties
            this.Property(t => t.Local)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PontoDeVendas");
            this.Property(t => t.PontoDeVendasId).HasColumnName("PontoDeVendasId");
            this.Property(t => t.EventoId).HasColumnName("EventoId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Local).HasColumnName("Local");

            // Relationships
            this.HasRequired(t => t.Evento)
                .WithMany(t => t.PontoDeVendas)
                .HasForeignKey(d => d.EventoId);     
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.PontoDeVendas)
                .HasForeignKey(d => d.UserId);
        }
    }
}
