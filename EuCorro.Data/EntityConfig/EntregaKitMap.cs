using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class EntregaKitMap : EntityTypeConfiguration<EntregaKit>
    {
        public EntregaKitMap()
        {
            // Primary Key
            HasKey(t => t.EntregaKitId);

            // Properties
            // Table & Column Mappings
            this.ToTable("EntregaKit");
            this.Property(t => t.EntregaKitId).HasColumnName("EntregaKitId");
            this.Property(t => t.EventoId).HasColumnName("EventoId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CPFRecebedor).HasColumnName("CPFRecebedor");
            this.Property(t => t.NomeRecebedor).HasColumnName("NomeRecebedor");
            this.Property(t => t.NumeroDoPeito).HasColumnName("NumeroDoPeito");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");       

            // Relationships
            this.HasRequired(t => t.Evento)
                .WithMany(t => t.EntregaKits)
                .HasForeignKey(d => d.EventoId);
            this.HasOptional(t => t.Usuario)
                .WithMany(t => t.EntregaKits)
                .HasForeignKey(d => d.UserId);     
        }
    }
}
