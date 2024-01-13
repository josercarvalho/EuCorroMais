using Eucorro.Domain.Models;

namespace Eucorro.Domain.Interfaces.Services
{
    public interface ICategoriaService : IServiceBase<Categoria>
    {
        Categoria GetByName(string name);
    }
}
