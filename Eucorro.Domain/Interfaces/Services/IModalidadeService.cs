using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Services
{
    public interface IModalidadeService : IServiceBase<Modalidade>
    {
        IEnumerable<Modalidade> GetByName(string name);
    }
}
