using System;
using System.Collections.Generic;
using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Models;
using System.Linq;

namespace EuCorro.Data.Repository
{
    public class ModalidadeEventoRepository : RepositoryBase<ModalidadeEvento>, IModalidadeEventoRepository
    {
        public IEnumerable<ModalidadeEvento> ListarModalidade()
        {
            return _db.ModalidadeEventos.ToList();
        }

        public IEnumerable<ModalidadeEvento> ListarModalidadePorEvento(int evento)
        {
            return _db.ModalidadeEventos.Where(p => p.EventoId.Equals(evento)).ToList();
        }

        public void RemoveEvento(int evento)
        {
            _db.ModalidadeEventos.RemoveRange(_db.ModalidadeEventos.Where(p => p.EventoId.Equals(evento)));
        }
    }
}
