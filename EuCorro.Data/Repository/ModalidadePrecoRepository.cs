﻿using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Models;
using System.Linq;

namespace EuCorro.Data.Repository
{
    public class ModalidadePrecoRepository : RepositoryBase<ModalidadePreco>, IModalidadePrecoRepository
    {
        public void RemmovePrco(int modalidade)
        {
            _db.ModalidadePrecos.RemoveRange(_db.ModalidadePrecos.Where(p => p.ModalidadeEventoId.Equals(modalidade)));
        }
    }
}
