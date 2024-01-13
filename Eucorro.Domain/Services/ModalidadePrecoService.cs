using System;
using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;

namespace Eucorro.Domain.Services
{
    public class ModalidadePrecoService : ServiceBase<ModalidadePreco>, IModalidadePrecoService
    {
        #region Global Declearation

        private readonly IModalidadePrecoRepository _modalidadePreco;

        #endregion

        #region Construtor

        public ModalidadePrecoService(IModalidadePrecoRepository repository) : base(repository)
        {
            _modalidadePreco = repository;
        }

        public void RemmovePrco(int modalidade)
        {
            _modalidadePreco.RemmovePrco(modalidade);
        }

        #endregion
    }
}
