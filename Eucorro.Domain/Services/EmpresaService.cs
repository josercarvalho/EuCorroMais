using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using Eucorro.Domain.Interfaces.Repositories;

namespace Eucorro.Domain.Services
{
    public class EmpresaService : ServiceBase<Empresa>, IEmpresaService
    {
        private readonly IEmpresaRepository _empresaServ;
        public EmpresaService(IEmpresaRepository repository) : base(repository)
        {
            _empresaServ = repository;
        }
    }
}
