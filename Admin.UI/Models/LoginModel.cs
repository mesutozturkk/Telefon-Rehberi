using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static TelefonRehberi.ENT.Entities;

namespace Admin.UI.Models
{
    public class LoginModel
    {
        public Kullanicilar Kullanicilar { get; set; }
        public string yeniSifre { get; set; }
        public string eskiSifre { get; set; }
    }
}