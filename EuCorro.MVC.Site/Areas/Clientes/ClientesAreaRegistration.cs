using System.Web.Mvc;

namespace EuCorro.MVC.Site.Areas.Clientes
{
    public class ClienteAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Clientes";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            string[] namespaces = new string[] {
                "EuCorro.MVC.Site.Areas.Clientes.Controllers"
            };

            context.MapRoute(
                name: "Clientes.Home.Index",
                url: "clientes",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: namespaces
            );
            context.MapRoute(
                name: "Clientes.Account.Login",
                url: "clientes/login",
                defaults: new { controller = "Account", action = "Login" },
                namespaces: namespaces
            );
            context.MapRoute(
                name: "Clientes.Account.LogOff",
                url: "clientes/logoff",
                defaults: new { controller = "Account", action = "LogOff" },
                namespaces: namespaces
            );
            context.MapRoute(
                name: "Clientes.Atleta.Create",
                url: "clientes/cadastro",
                defaults: new { controller = "Account", action = "Register" },
                namespaces: namespaces
            );
            context.MapRoute(
                name: "Clientes.Atleta.Edit",
                url: "clientes/meusdados",
                defaults: new { controller = "Atleta", action = "Edit" },
                namespaces: namespaces
            );
            context.MapRoute(
                name: "Clientes.Account.ForgotPassword",
                url: "clientes/esquecisenha",
                defaults: new { controller = "Account", action = "ForgotPassword" },
                namespaces: namespaces
            );
        }
    }
}