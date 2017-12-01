using Admin.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static TelefonRehberi.BL.BusinessManager;
using static TelefonRehberi.BL.DTOS.DTOs;

namespace Admin.UI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel m)
        {

            try
            {
                KullaniciManager km = new KullaniciManager();
                KullaniciDTO kullaniciDto = km.Denetle(m.Kullanicilar.UserId, m.Kullanicilar.Sifre);
                Session["Kullanici"] = kullaniciDto.UserId;
                Session["Rol"] = kullaniciDto.RolAd;
                if (Session["Rol"].ToString() == "Admin")
                {
                    return RedirectToAction("Index", "Home");
                }
                
                else
                    return RedirectToAction("Hata", "Login");
            }
            catch (Exception)
            {
                return RedirectToAction("Hata2", "Login");

            }

        }
        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public ActionResult Hata()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Hata2()
        {

            return View();
        }
    }
}