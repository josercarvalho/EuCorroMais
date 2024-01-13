using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class ModalidadePrecoMap : EntityTypeConfiguration<ModalidadePreco>
    {

        public ModalidadePrecoMap()
        {
            // Primary Key
            HasKey(t => t.ModalidadePrecoId);

            // Properties
            Property(t => t.HoraIni)
                .HasMaxLength(5);

            Property(t => t.HoraFin)
                .HasMaxLength(5);

            // Table & Column Mappings
            ToTable("ModalidadePreco");
            Property(t => t.ModalidadePrecoId).HasColumnName("ModalidadePrecoId");
            Property(t => t.ModalidadeEventoId).HasColumnName("ModalidadeEventoId");
            Property(t => t.TipoIncricao).HasColumnName("TipoIncricao");
            Property(t => t.DataIni).HasColumnName("DataIni");
            Property(t => t.DataFin).HasColumnName("DataFin");
            Property(t => t.HoraIni).HasColumnName("HoraIni");
            Property(t => t.HoraFin).HasColumnName("HoraFin");
            Property(t => t.Valor).HasColumnName("Valor");
            Property(t => t.Desconto).HasColumnName("Desconto");
            Property(t => t.TipoDesconto).HasColumnName("TipoDesconto");
            Property(t => t.CodigoDesconto).HasColumnName("CodigoDesconto");
            Property(t => t.ValidadeDesconto).HasColumnName("ValidadeDesconto");

            // Relationships
            HasRequired(t => t.ModalidadeEvento)
                .WithMany(t => t.ModalidadePrecos)
                .HasForeignKey(d => d.ModalidadeEventoId);
        }
    }
}
