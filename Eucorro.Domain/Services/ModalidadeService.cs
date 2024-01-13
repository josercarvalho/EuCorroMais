using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Eucorro.Domain.Services
{
    public class ModalidadeService : ServiceBase<Modalidade>, IModalidadeService
    {
        private readonly IModalidadesRepository _servModalidade;
        public ModalidadeService(IModalidadesRepository repository) : base(repository)
        {
            _servModalidade = repository;
        }

        public IEnumerable<Modalidade> GetByName(string name)
        {
            return _servModalidade.GetAll().Where(x => x.Nome.Contains(name));
        }
    }
}
