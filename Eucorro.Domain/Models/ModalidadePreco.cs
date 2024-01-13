using Eucorro.Domain.MetaData;
using System;
using System.ComponentModel.DataAnnotations;

namespace Eucorro.Domain.Models
{
    [MetadataType(typeof(ModalidadePrecoMetaData))]
    public class ModalidadePreco
    {
        public int ModalidadePrecoId { get; set; }
        public int ModalidadeEventoId { get; set; }
        public int TipoIncricao { get; set; } // 0 - GRATUITA, 1 - PAGA
        public DateTime DataIni { get; set; }
        public DateTime DataFin { get; set; }
        public string HoraIni { get; set; }
        public string HoraFin { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; } // 0 - SEM DESCONTO.
        public int TipoDesconto { get; set; } // Tipo de Desconto 0 = R$ (moeda), 1 = % (percentual)
        public string CodigoDesconto { get; set; }
        public DateTime ValidadeDesconto { get; set; }

        public virtual ModalidadeEvento ModalidadeEvento { get; set; }

    }
}
