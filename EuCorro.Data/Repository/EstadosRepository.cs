﻿using Eucorro.Domain.Interfaces.Repositories;
using Eucorro.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace EuCorro.Data.Repository
{
    public class EstadosRepository : RepositoryBase<Estado>, IEstadosRepository
    {
        public IEnumerable<Estado> BuscarPorPais(int pais)
        {
            return _db.Estados.Where(p => p.PaisId == pais);
        }
    }
}
