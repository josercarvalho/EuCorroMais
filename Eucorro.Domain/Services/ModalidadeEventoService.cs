using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using System.Collections.Generic;
using System;

namespace Eucorro.Domain.Services
{
    public class ModalidadeEventoService : ServiceBase<ModalidadeEvento>, IModalidadeEventoService
    {
        #region Global Declearation

        private readonly IModalidadeEventoRepository _modalidadeEvento;

        #endregion

        #region Construtor

        public ModalidadeEventoService(IModalidadeEventoRepository repository) : base(repository)
        {
            _modalidadeEvento = repository;
        }

        public IEnumerable<ModalidadeEvento> ListarModalidade()
        {
            return _modalidadeEvento.ListarModalidade();
        }

        public IEnumerable<ModalidadeEvento> ListarModalidadePorEvento(int evento)
        {
            return _modalidadeEvento.ListarModalidadePorEvento(evento);
        }

        public void RemoveEvento(int evento)
        {
            _modalidadeEvento.RemoveEvento(evento);
        }

        #endregion

    }
}
