using Eucorro.Domain.Models;
using System.Collections;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Repositories
{
    public interface IEventosRepository : IRepositoryBase<Evento>
    {
        void RemoveEvento(int evento);
        IEnumerable<Evento> ProximosEventos();
    }
}
