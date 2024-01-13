using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using System.Linq;

namespace Eucorro.Domain.Services
{
    public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
    {
        #region Global Declearation

        private readonly ICategoriasRepository _categoria;

        #endregion

        #region Constructor

        public CategoriaService(ICategoriasRepository repository) : base(repository)
        {
            _categoria = repository;
        }

        #endregion

        #region Interface Implementation

        public Categoria GetByName(string name)
        {
            return _categoria.GetAll().FirstOrDefault(x => x.Nome.Equals(name));
        }

        #endregion

        #region Private Methods

        #endregion   
    }
}
