using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Services
{
    public interface ICidadesService : IServiceBase<Cidade>
    {
        IEnumerable<Cidade> BuscarPorEstado(int estado);
    }
}
