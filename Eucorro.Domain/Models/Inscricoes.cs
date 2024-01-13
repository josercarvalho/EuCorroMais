using Eucorro.Domain.Enum;
using Eucorro.Domain.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eucorro.Domain.Models
{
    [MetadataType(typeof(InscricoesMetaData))]       
    public class Inscricoes 
    {
        public Inscricoes()
        {
            Usuarios = new List<Usuario>();
        }

        public int InscricoesId { get; set; }
        public int EventoId { get; set; }
        public string UserId { get; set; }
        public int ModalidadeEventoId { get; set; }
        //public Camiseta Camiseta { get; set; }
        public decimal Valor { get; set; }
        //public bool DescontoIdoso { get; set; }
        public decimal ValorBoleto { get; set; }
        public decimal ValorTotal { get; set; }
        //public int Numero { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        //public int? Modalidade_ModalidadeId { get; set; }
        public virtual Evento Evento { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ModalidadeEvento ModalidadeEvento { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
