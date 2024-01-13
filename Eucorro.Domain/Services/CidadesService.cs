using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Services
{
    public class CidadesService : ServiceBase<Cidade>, ICidadesService
    {
        private readonly ICidadesRepository _cidadeRepository;

        public CidadesService(ICidadesRepository cidadeRepository)
            : base(cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public IEnumerable<Cidade> BuscarPorEstado(int estado)
        {
            return _cidadeRepository.BuscarPorEstado(estado);
        }
    }
}
