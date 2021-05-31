using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andino_Cristian_LPPA_Parcial1.App_Start
{
    public class FilterConfig
    {
            public static void RegisterGlobalFilters(GlobalFilterCollection filters)
            {
                filters.Add(new HandleErrorAttribute());
                filters.Add(new AuthorizeAttribute()); 
                                                       
            }
            //HTTP Error 404.15 - Not Found porque no tengo el decorado de autorizacion, por defecto lo pone como
            //[Authorize] en el controller y se llama recursivamente, se debe agregar en el controller [AllowAnonymous]
    }
}