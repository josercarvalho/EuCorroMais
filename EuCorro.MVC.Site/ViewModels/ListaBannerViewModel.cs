using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EuCorro.MVC.Site.ViewModels
{
    public class ListaBannerViewModel
    {
        public int EventoId { get; set; }
        public string Banner { get; set; }
        public string Nome { get; set; }
        public DateTime DataEvento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public String URL { get; set; }
        public TimeSpan Previsao { get; set; }
    }
}