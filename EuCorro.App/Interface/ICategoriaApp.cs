using Eucorro.Domain.Models;

namespace EuCorro.App.Interface
{
    public interface ICategoriaApp : IAppServiceBase<Categoria>
    {
        Categoria GetByName(string name);
    }
}
