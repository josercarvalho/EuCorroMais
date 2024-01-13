using System;
using System.Collections.Generic;

namespace Eucorro.Domain.Models
{
    public class Modalidade 
    {
        public Modalidade()
        {
            Eventos = new List<Evento>();
        }

        public int ModalidadeId { get; set; }
        public int? CategoriaId { get; set; }
        public string Nome { get; set; }
        public int Distancia { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
    }
}
