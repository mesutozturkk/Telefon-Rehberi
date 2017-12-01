using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static TelefonRehberi.BL.BusinessManager;

namespace Admin.UI.Controllers
{
    [AuthorizationAdmin]
    public class AdminController : Controller
    {
        // GET: Admin

        public ActionResult Admin()
        {
            return View();
        }
       
    }

}
