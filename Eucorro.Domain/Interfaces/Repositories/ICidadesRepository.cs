using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Repositories
{
    public interface ICidadesRepository : IRepositoryBase<Cidade>
    {
        IEnumerable<Cidade> BuscarPorEstado(int estado);
        Cidade BuscarPorNome(string nome);
    }
}
