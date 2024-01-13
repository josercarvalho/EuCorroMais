using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Services
{
    public interface IModalidadeEventoService : IServiceBase<ModalidadeEvento>
    {
        IEnumerable<ModalidadeEvento> ListarModalidadePorEvento(int evento);
        IEnumerable<ModalidadeEvento> ListarModalidade();
        void RemoveEvento(int evento);
    }
}
