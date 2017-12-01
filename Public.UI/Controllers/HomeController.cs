using Public.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static TelefonRehberi.BL.BusinessManager;
using static TelefonRehberi.ENT.Entities;

namespace Public.UI.Controllers
{
    public class HomeController : Controller
    {
        CalisanManager cm = new CalisanManager();
        public ActionResult Index()
        {
            CalisanlarModel cmodel = new CalisanlarModel();
            cmodel.clist = cm.CalisanListele();
            return View(cmodel);
        }
        public ActionResult Detay(int id,CalisanlarModel model)
        {
            Calisanlar calisanlar = cm.Bul(id);
            model.Calisanlar = calisanlar;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}