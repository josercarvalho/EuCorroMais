using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Services
{
    public interface IEstadosService : IServiceBase<Estado>
    {
        IEnumerable<Estado> BuscaEstados();
    }
}
