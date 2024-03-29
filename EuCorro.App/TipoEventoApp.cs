﻿using Eucorro.Domain.Interfaces.Services;
using Eucorro.Domain.Models;
using EuCorro.App.Interface;

namespace EuCorro.App
{
    public class TipoEventoApp : AppServiceBase<EventoTipo>, ITipoEventoApp
    {
        private readonly ITipoEventoService _eventoTipo;
        public TipoEventoApp(ITipoEventoService serviceBase) : base(serviceBase)
        {
            _eventoTipo = serviceBase;
        }
    }
}
