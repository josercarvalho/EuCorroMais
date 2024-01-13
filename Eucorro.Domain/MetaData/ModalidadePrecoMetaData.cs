using System;
using System.ComponentModel.DataAnnotations;

namespace Eucorro.Domain.MetaData
{
    public class ModalidadePrecoMetaData
    {
        [Key]
        public int ModalidadePrecoId { get; set; }

        public int ModalidadeEventoId { get; set; }

        [Required]
        [Display(Name = "Tipo de inscrição")]
        public int TipoIncricao { get; set; } // 0 - GRATUITA, 1 - PAGA

        [Required]
        [Display(Name = "Data inicial")]
        public DateTime DataIni { get; set; }

        [Required]
        [Display(Name = "Data final")]
        public DateTime DataFin { get; set; }

        [Required]
        [Display(Name = "Hora inícial")]
        public string HoraIni { get; set; }

        [Required]
        [Display(Name = "Encerramento")]
        public string HoraFin { get; set; }

        public decimal Valor { get; set; }

        [Display(Name = "Valor do desconto")]
        public decimal Desconto { get; set; } // 0 - SEM DESCONTO.

        [Display(Name = "Tipo de desconto")]
        public int TipoDesconto { get; set; } // Tipo de Desconto 0 = R$ (moeda), 1 = % (percentual)

        [Display(Name = "*Código do desconto")]
        public string CodigoDesconto { get; set; }

        [Display(Name = "Válido até")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime ValidadeDesconto { get; set; }
    }
}
