using EuCorro.App.Interface;
using EuCorro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuCorro.Domain.Interfaces.Services;

namespace EuCorro.App
{
    public class InscricaoApp : AppServiceBase<Inscricoes>, IInscricaoApp
    {
        private readonly IInscricaoApp _inscricao;
        public InscricaoApp(IInscricaoApp serviceBase) : base(serviceBase)
        {
            _inscricao = serviceBase;
        }

        public ModalidadeCategoria BuscarCategoria(int evento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estado> BuscarEstados()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cidade> BuscarPorEstado(int estado)
        {
            throw new NotImplementedException();
        }

        public ModalidadePreco BuscarPrecoPorModadlidade(int evento)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarUsuario(string usuario)
        {
            throw new NotImplementedException();
        }

        public void CadastraInscricao(Inscricoes inscricao)
        {
            throw new NotImplementedException();
        }

        public void CadastrarPagamento(int inscricao)
        {
            throw new NotImplementedException();
        }

        public void IncluirInscrito(Inscritos inscrito)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> ListarEventos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inscritos> ListarInscritos(int inscricao)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ModalidadeEvento> ListarModalidadeEvento(int evento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modalidade> ListarModalidades()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inscricoes> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventoTipo> ListarTipoEvento()
        {
            throw new NotImplementedException();
        }

        public void Removeinscricao(int inscricao)
        {
            throw new NotImplementedException();
        }

        public void RemoveInscrito(int inscrito)
        {
            throw new NotImplementedException();
        }
    }
}
