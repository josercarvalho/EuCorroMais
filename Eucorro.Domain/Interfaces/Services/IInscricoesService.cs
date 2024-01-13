using Eucorro.Domain.Models;

namespace Eucorro.Domain.Interfaces.Services
{
    public interface IInscricoesService : IServiceBase<Inscricoes>
    {
        int TotalInscritos();
    }
}
