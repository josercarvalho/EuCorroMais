using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using EuCorro.App.Interface;

namespace EuCorro.App
{
    public class CategoriaApp : AppServiceBase<Categoria>, ICategoriaApp
    {
        private readonly ICategoriaService _categoria;
        public CategoriaApp(ICategoriaService serviceBase) : base(serviceBase)
        {
            _categoria = serviceBase;
        }

        public Categoria GetByName(string name)
        {
            return _categoria.GetByName(name);
        }
    }
}
