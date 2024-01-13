using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Repositories
{
    public interface IPerfilUsuarioRepository : IRepositoryBase<PerfilUsuario>
    {
        List<Usuario> BuscarClientePerfil(int perfilCliente);
    }
}
