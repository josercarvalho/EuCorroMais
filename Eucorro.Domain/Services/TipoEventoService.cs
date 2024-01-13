using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;

namespace Eucorro.Domain.Services
{
    public class TipoEventoService : ServiceBase<EventoTipo>, ITipoEventoService
    {
        private readonly ITipoEventoRepository _tipoServ;
        public TipoEventoService(ITipoEventoRepository repository) : base(repository)
        {
            _tipoServ = repository;
        }
    }                     
}
