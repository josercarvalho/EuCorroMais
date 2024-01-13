using EuCorro.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eucorro.Domain.MetaData
{
    public class InscritosMetaData
    {
        [Key]
        public int InscritosId { get; set; }
        public int InscricoesId { get; set; }
        public int EventoId { get; set; }
        public string UserId { get; set; }
        public int ModalidadeEventoId { get; set; }
        public int Categoria { get; set; }
        public Camiseta Camiseta { get; set; }
        public decimal Valor { get; set; }
        public bool DescontoIdoso { get; set; }
        public decimal ValorServico { get; set; }
        public decimal ValorBoleto { get; set; }
        public int Numero { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
