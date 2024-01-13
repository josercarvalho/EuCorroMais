using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Eucorro.Domain.Services
{
    public class EstadosService : ServiceBase<Estado>, IEstadosService
    {
        private readonly IEstadosRepository _estado;
        public EstadosService(IEstadosRepository repository) : base(repository)
        {
            _estado = repository;
        }

        public IEnumerable<Estado> BuscaEstados()
        {
            return _estado.GetAll().OrderBy(x => x.Nome);
        }
    }
}
