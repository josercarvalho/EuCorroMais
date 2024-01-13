using Eucorro.Domain.Models;

namespace Eucorro.Domain.Interfaces.Repositories
{
    public interface IModalidadePrecoRepository : IRepositoryBase<ModalidadePreco>
    {
        void RemmovePrco(int modalidade);
    }
}
