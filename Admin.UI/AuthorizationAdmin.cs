using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.UI
{

    public class AuthorizationAdmin : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["Rol"].ToString() != "Admin")
            {
                filterContext.Result = new RedirectResult("/Login/Login");
            }
           
        }
    }
}