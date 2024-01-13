using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using EuCorro.App.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EuCorro.App
{
    public class EventoApp : AppServiceBase<Evento>, IEventoApp
    {
        #region Global Declearation

        private readonly IEventosService _evento;
        private readonly IModalidadeService _modalidade;
        private readonly ICategoriaService _categoria;
        private readonly IModalidadeEventoService _modalidadeEvento;
        private readonly IModalidadePrecoService _modalidadePreco;
        private readonly IEstadosService _estado;
        private readonly ICidadesService _cidade;
        private readonly ITipoEventoService _tipoEve;

        #endregion

        #region Constructor

        public EventoApp(IEventosService serviceBase,
                ICategoriaService categoria,
                IModalidadeService modalidade,
                IModalidadePrecoService modalidadePreco,
                IModalidadeEventoService modalidadeEvento,
                ITipoEventoService tipoEve,
                IEstadosService estados, ICidadesService cidades) : base(serviceBase)
        {
            _evento = serviceBase;
            _categoria = categoria;
            _modalidade = modalidade;
            _modalidadePreco = modalidadePreco;
            _modalidadeEvento = modalidadeEvento;
            _estado = estados;
            _cidade = cidades;
            _tipoEve = tipoEve;
        }

        #endregion

        #region Interface Implementation

        public IEnumerable<Cidade> BuscarPorEstado(int estado)
        {
            return _cidade.BuscarPorEstado(estado);
        }

        public IEnumerable<Evento> BuscarPorNome(string nome)
        {
            return _evento.GetByName(nome);
        }

        public void CadastraEvento(Evento evento)
        {
            _evento.Add(evento);
        }

        public void IncluirCategoria(Categoria categoria)
        {
            _categoria.Add(categoria);
        }

        public void IncluirModalidade(ModalidadeEvento modalidadeEvento)
        {
            _modalidadeEvento.Add(modalidadeEvento);
        }

        public void IncluirPrecoModalidade(ModalidadePreco modalidadePreco)
        {
            _modalidadePreco.Add(modalidadePreco);
        }

        public EventoForm InitializePageData()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> ListarCategorias()
        {
            return _categoria.GetAll();
        }

        public IEnumerable<Modalidade> ListarModalidades()
        {
            return _modalidade.GetAll();
        }

        public IEnumerable<EventoTipo> ListarTipoEvento()
        {
            return _tipoEve.GetAll();
        }

        public IEnumerable<Estado> BuscarEstados()
        {
            return _estado.BuscaEstados();
        }

        public IEnumerable<ModalidadeEvento> ListarModalidadeEvento(int evento)
        {
            return _modalidadeEvento.ListarModalidadePorEvento(evento);
        }

        public ModalidadeEvento BuscarModalidade(int id)
        {
            return _modalidadeEvento.GetById(id);
        }

        public void RemoveEvento(int evento)
        {
            var modalidade = _modalidadeEvento.ListarModalidadePorEvento(evento);

            if (modalidade != null)
            {
                foreach (var item in modalidade)
                {
                    _modalidadePreco.RemmovePrco(item.ModalidadeEventoId);
                    _modalidadeEvento.Remove(item);
                }
            }
            Evento eventoDel = _evento.GetById(evento);
            _evento.Remove(eventoDel);
        }

        public void RemoveModalidade(ModalidadeEvento modalidade)
        {
            _modalidadeEvento.Remove(modalidade);
        }

        public IEnumerable<Evento> ProximosEventos()
        {
            return _evento.ProximosEventos();
        }

        #endregion
    }
}
