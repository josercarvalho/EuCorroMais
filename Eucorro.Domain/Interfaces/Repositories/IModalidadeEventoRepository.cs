using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace Eucorro.Domain.Interfaces.Repositories
{
    public interface IModalidadeEventoRepository : IRepositoryBase<ModalidadeEvento>
    {
        IEnumerable<ModalidadeEvento> ListarModalidadePorEvento(int evento);
        IEnumerable<ModalidadeEvento> ListarModalidade();
        void RemoveEvento(int evento);
    }
}
