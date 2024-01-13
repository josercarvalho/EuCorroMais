using System;
using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Models;
using System.Linq;
using System.Collections.Generic;

namespace EuCorro.Data.Repository
{
    public class EventosRepository : RepositoryBase<Evento>, IEventosRepository
    {
        public IEnumerable<Evento> ProximosEventos()
        {
            return _db.Eventos.Where(p => p.Status.Equals(0) && p.DataEvento > DateTime.Now).Take(3);
        }

        public void RemoveEvento(int evento)
        {
            _db.Eventos.RemoveRange(_db.Eventos.Where(p=>p.EstadoId.Equals(evento)));
        }
    }
}
