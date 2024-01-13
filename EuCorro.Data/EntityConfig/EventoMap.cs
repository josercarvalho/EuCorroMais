using Eucorro.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace EuCorro.Data.EntityConfig
{
    public class EventoMap : EntityTypeConfiguration<Evento>
    {
        public EventoMap()
        {
            // Primary Key
            HasKey(t => t.EventoId);

            // Properties
            Property(t => t.Nome)
                .HasMaxLength(150);

            Property(t => t.URL)
                .HasMaxLength(100);

            Property(t => t.FoneContato)
                .HasMaxLength(15);

            Property(t => t.EmailContato)
                .HasMaxLength(100);

            Property(t => t.HoraEncerramento)
                .HasMaxLength(19);

            Property(t => t.Endereco)
                .HasMaxLength(100);

            Property(t => t.DescricaoEvento)
                .HasMaxLength(8000);

            Property(t => t.Regulamento)
                .HasMaxLength(100);

            Property(t => t.InformacaoKit)
                .HasMaxLength(100);

            Property(t => t.ImagemKit)
                .HasMaxLength(100);

            Property(t => t.BannerEvento)
                .HasMaxLength(100);

            Property(t => t.BannerPatrocinio)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Evento");
            //Property(t => t.EventoId).HasColumnName("EventoId");
            //Property(t => t.EventoTipoId).HasColumnName("EventoTipoId");
            //Property(t => t.ModalidadeId).HasColumnName("ModalidadeId");
            //Property(t => t.CategoriaId).HasColumnName("CategoriaId");
            //Property(t => t.DataEvento).HasColumnName("DataEvento");
            //Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            //Property(t => t.Nome).HasColumnName("Nome");
            //Property(t => t.URL).HasColumnName("URL");
            //Property(t => t.FoneContato).HasColumnName("FoneContato");
            //Property(t => t.EmailContato).HasColumnName("EmailContato");
            //Property(t => t.Instritos).HasColumnName("Instritos");
            //Property(t => t.DataEncerramento).HasColumnName("DataEncerramento");
            //Property(t => t.HoraEncerramento).HasColumnName("HoraEncerramento");
            //Property(t => t.Endereco).HasColumnName("Endereco");
            //Property(t => t.EstadoId).HasColumnName("EstadoId");
            //Property(t => t.CidadeId).HasColumnName("CidadeId");
            //Property(t => t.DescricaoEvento).HasColumnName("DescricaoEvento");
            //Property(t => t.Regulamento).HasColumnName("Regulamento");
            //Property(t => t.InformacaoKit).HasColumnName("InformacaoKit");
            //Property(t => t.ImagemKit).HasColumnName("ImagemKit");
            //Property(t => t.BannerEvento).HasColumnName("BannerEvento");
            //Property(t => t.BannerPatrocinio).HasColumnName("BannerPatrocinio");
            //Property(t => t.Ativo).HasColumnName("Ativo");
            //Property(t => t.Status).HasColumnName("Status");

            // Relationships
            HasRequired(t => t.EventoTipo)
                .WithMany(t => t.Eventos)
                .HasForeignKey(d => d.EventoTipoId);
            HasRequired(t => t.Modalidade)
                .WithMany(t => t.Eventos)
                .HasForeignKey(d => d.ModalidadeId);
            //HasOptional(t => t.Categoria)
            //    .WithMany(t => t.Eventos)
            //    .HasForeignKey(d => d.CategoriaId);
        }
    }
}
