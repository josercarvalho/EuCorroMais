using Eucorro.Domain.Models;

namespace Eucorro.Domain.Interfaces.Services
{
    public interface IModalidadePrecoService : IServiceBase<ModalidadePreco>
    {
        void RemmovePrco(int modalidade);
    }
}
