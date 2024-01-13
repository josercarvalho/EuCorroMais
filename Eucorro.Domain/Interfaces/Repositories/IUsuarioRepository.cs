using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        void DesativarLock(string id);
        Usuario RecuperarUsuarioPorEmail(string email);
        Usuario BuscarCPF(string cpf);
        IEnumerable<Usuario> BuscarPorNome(string nome);
    }
}
