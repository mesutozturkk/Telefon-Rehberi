using Admin.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static TelefonRehberi.BL.BusinessManager;
using static TelefonRehberi.ENT.Entities;

namespace Admin.UI.Controllers
{
    [AuthorizationAdmin]
    public class DepartmanController : Controller
    {
        DepartmanManager dm = new DepartmanManager();
        public ActionResult Index()
        {
            DepartmanModel model = new DepartmanModel();
            model.dlist = dm.DepartmanListele();
            return View(model);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(DepartmanModel dmodel)
        {
            Departman departman = new Departman();
            departman.DepartmanAd = dmodel.Departman.DepartmanAd;
            dm.Ekle(departman);
            dm.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            DepartmanModel dmodel = new DepartmanModel();
            dmodel.Departman = dm.Bul(id);
            return View(dmodel);
        }
        [HttpPost]
        public ActionResult Guncelle(DepartmanModel dmodel,int id)
        {
            Departman departman = dm.Bul(id);
            departman.DepartmanAd = dmodel.Departman.DepartmanAd;
            dm.Guncelle(departman);
            dm.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            Session["silme"]=dm.DepartmanSil(id);
            return RedirectToAction("Index");
        }
    }
}
