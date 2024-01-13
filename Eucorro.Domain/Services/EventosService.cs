using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Eucorro.Domain.Services
{
    public class EventosService : ServiceBase<Evento>, IEventosService
    {
        private readonly IEventosRepository _evento;
        public EventosService(IEventosRepository repository) : base(repository)
        {
            _evento = repository;
        }

        public int EventosRealizados()
        {
            return _evento.GetAll().Where(x => x.Status.Equals(2)).Count();
        }

        public IEnumerable<Evento> GetByName(string nome)
        {
            return _evento.GetAll().Where(x => x.Nome.Contains(nome));
        }

        public IEnumerable<Evento> ListarAtivos()
        {
            return _evento.GetAll().Where(x => x.Ativo.Equals(true)).OrderByDescending(x => x.DataEvento);
        }

        public IEnumerable<Evento> ListarInativos()
        {
            return _evento.GetAll().Where(x => x.Ativo.Equals(false)).OrderByDescending(x => x.DataEvento);
        }

        public IEnumerable<Evento> ProximosEventos()
        {
            return _evento.ProximosEventos();
        }

        public void RemoveEvento(int evento)
        {
            _evento.RemoveEvento(evento);
        }
    }
}
