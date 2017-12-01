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
    public class HomeController : Controller
    {
        CalisanManager cm = new CalisanManager();
        DepartmanManager dm = new DepartmanManager();
        KullaniciManager km = new KullaniciManager();

        public ActionResult Index()
        {
            CalisanlarModel cmodel = new CalisanlarModel();
            cmodel.clist = cm.CalisanListele();
            return View(cmodel);
        }


        public ActionResult Sil(int id)
        {
            Calisanlar calisanlar = cm.Bul(id);
            cm.Sil(calisanlar);
            cm.Save();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            CalisanlarModel cmodel = new CalisanlarModel();
            cmodel.Calisanlar = cm.Bul(id);
            DropDownDoldur(cmodel);
            return View(cmodel);
           
        }

        private void DropDownDoldur(CalisanlarModel cmodel)
        {
            cmodel.DepartmanForDropDown=dm.Set().Select(x => new SelectListItem()
            {
                Text = x.DepartmanAd,
                Value = x.DepartmanId.ToString()
            }).ToList();
            cmodel.YöneticiForDropDown = cm.Set().Select(x => new SelectListItem()
            {
                Text = x.CalisanAd,
                Value = x.CalisanId.ToString()
            }).ToList();

        }

        [HttpPost]
        public ActionResult Guncelle(CalisanlarModel model, int id)
        {
            Calisanlar calisanlar = cm.Bul(id);
            calisanlar.CalisanAd = model.Calisanlar.CalisanAd;
            calisanlar.CalisanSoyad = model.Calisanlar.CalisanSoyad;
            calisanlar.CalisanTelefon = model.Calisanlar.CalisanTelefon;
            calisanlar.DepartmanId = model.Calisanlar.DepartmanId;
            calisanlar.YöneticiId = model.Calisanlar.YöneticiId;
            cm.Guncelle(calisanlar);
            cm.Save();
            return RedirectToAction("Index");
        }


        public ActionResult Detay(int id, CalisanlarModel model)
        {
            Calisanlar calisanlar  = cm.Bul(id);
            model.Calisanlar = calisanlar;
            return View(model);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            CalisanlarModel model = new CalisanlarModel();
            DropDownDoldur(model);
            return View(model);
        }
        [HttpPost]
        public ActionResult Ekle(CalisanlarModel model)
        {
            Calisanlar calisanlar = new Calisanlar();
            calisanlar.CalisanAd = model.Calisanlar.CalisanAd;
            calisanlar.CalisanSoyad = model.Calisanlar.CalisanSoyad;
            calisanlar.CalisanTelefon = model.Calisanlar.CalisanTelefon;
            calisanlar.DepartmanId = model.Calisanlar.DepartmanId;
            calisanlar.YöneticiId = model.Calisanlar.YöneticiId;
            cm.Ekle(calisanlar);
            cm.Save();

            return RedirectToAction("Index");

        }
     
        [HttpGet]
        public ActionResult SifreDegistir()
        {
            string id = Session["Kullanici"].ToString();
            LoginModel model = new LoginModel();
            model.Kullanicilar = km.Bul(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult SifreDegistir(LoginModel lm )
        {
            string id = Session["Kullanici"].ToString();
            bool sonuc=km.SifreDegistir(id, lm.eskiSifre, lm.yeniSifre);

            if (sonuc)
            {
                Session["HataMesj"] = "";
                return RedirectToAction("Index");
            }
            else
            {
                Session["HataMesj"]="Şifre Değiştirilemedi";
                return RedirectToAction("SifreDegistir");
            }
        }
    }
}