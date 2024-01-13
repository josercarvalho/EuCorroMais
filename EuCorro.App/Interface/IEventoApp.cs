using Eucorro.Domain.Models;
using System.Collections.Generic;

namespace EuCorro.App.Interface
{
    public interface IEventoApp : IAppServiceBase<Evento>
    {

        #region Categorias

        IEnumerable<Categoria> ListarCategorias();

        void IncluirCategoria(Categoria categoria);

        #endregion

        #region Dados do Evento

        IEnumerable<Evento> BuscarPorNome(string nome);
        IEnumerable<Estado> BuscarEstados();
        IEnumerable<Cidade> BuscarPorEstado(int estado);
        IEnumerable<EventoTipo> ListarTipoEvento();
        IEnumerable<Evento> ProximosEventos();

        void CadastraEvento(Evento evento);
        void RemoveEvento(int evento);

        /// <summary>
        /// Get all initialization data for listagens da página
        /// </summary>
        /// <returns></returns>
        EventoForm InitializePageData();

        #endregion

        #region Modalidade

        ModalidadeEvento BuscarModalidade(int id);

        IEnumerable<Modalidade> ListarModalidades();

        IEnumerable<ModalidadeEvento> ListarModalidadeEvento(int evento);

        void IncluirModalidade(ModalidadeEvento modalidade);

        void IncluirPrecoModalidade(ModalidadePreco preco);

        void RemoveModalidade(ModalidadeEvento modalidade);

        #endregion
    }
}
