using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eucorro.Domain.Services
{
    public class PerfilUsuarioService : ServiceBase<PerfilUsuario>, IPerfilUsuarioService
    {
        private readonly IPerfilUsuarioRepository _repositorioDePerfilDeUsuario;
        public PerfilUsuarioService(IPerfilUsuarioRepository repositorioDePerfilDeUsuario)
            : base(repositorioDePerfilDeUsuario)
        {
            _repositorioDePerfilDeUsuario = repositorioDePerfilDeUsuario;
        }

        public List<Usuario> BuscarClientePerfil(int perfilCliente)
        {
            return _repositorioDePerfilDeUsuario.BuscarClientePerfil(perfilCliente);
        }
    }
}
