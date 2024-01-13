using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Repositories
{
    public interface IEstadosRepository : IRepositoryBase<Estado>
    {
        IEnumerable<Estado> BuscarPorPais(int pais);
    }
}
