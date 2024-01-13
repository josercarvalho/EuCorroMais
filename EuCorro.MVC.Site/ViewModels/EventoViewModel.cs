using Eucorro.Domain.Models;
using System;
using System.Collections.Generic;

namespace EuCorro.MVC.Site.ViewModels
{
    public class EventoViewModel
    {
        public int EventoId { get; set; }
        public int EventoTipoId { get; set; }
        public int ModalidadeId { get; set; }
        public int UserId { get; set; }
        public DateTime DataEvento { get; set; }
        public string HoraEvento { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public string URL { get; set; }
        public string FoneContato { get; set; }
        public string EmailContato { get; set; }
        public int Instritos { get; set; }
        public DateTime DataEncerramento { get; set; }
        public string HoraEncerramento { get; set; }
        public string Endereco { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }
        public string DescricaoEvento { get; set; }
        public string Regulamento { get; set; }
        public string InformacaoKit { get; set; }
        public string ImagemKit { get; set; }
        public string BannerEvento { get; set; }
        public string BannerPatrocinio { get; set; }
        public bool Ativo { get; set; }
        public int Status { get; set; }

        public Modalidade Modalidade { get; set; }
        public ModalidadeEvento ModalidadeEvento { get; set; }
        public Categoria Categoria { get; set; }
        public IEnumerable<ModalidadeEvento> Modalidades { get; set; }
        public List<Categoria> Categorias { get; set; }
    }
}