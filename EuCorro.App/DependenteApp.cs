using EuCorro.Domain.Models;
using EuCorro.App.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuCorro.Domain.Interfaces.Services;

namespace EuCorro.App
{
    public class DependenteApp : AppServiceBase<Dependentes>, IDependenteApp
    {
        private readonly IDependenteService _dependentes;
        public DependenteApp(IDependenteService serviceBase) : base(serviceBase)
        {
            _dependentes = serviceBase;
        }
    }
}
