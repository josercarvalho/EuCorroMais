using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using System.Linq;

namespace Eucorro.Domain.Services
{
    public class InscricoesService : ServiceBase<Inscricoes>, IInscricoesService
    {
        #region Global Declearation

        private readonly IInscricoesRepository _inscricoes;

        #endregion

        #region Construtor

        public InscricoesService(IInscricoesRepository inscricoes) : base(inscricoes)
        {
            _inscricoes = inscricoes;
        }

        #endregion

        #region Interface Implementation

        public int TotalInscritos()
        {
            return _inscricoes.GetAll().Where(x => x.Status.Equals(true)).Count();
        }

        #endregion
    }
}
