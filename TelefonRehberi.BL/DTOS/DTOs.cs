using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi.BL.DTOS
{
    public class DTOs
    {
        public class CalisanDTO
        {

            public int CalisanId { get; set; }
            public string CalisanAd { get; set; }
            public string CalisanSoyad { get; set; }
            public string CalisanTelefon { get; set; }
            public int DepartmanId { get; set; }
            public int? YöneticiId { get; set; }
            public int RolId { get; set; }

        }
        public class KullaniciDTO
        {
            public string RolAd { get; set; }
            public string UserId { get; set; }
            public string CalisanAd { get; set; }

        }
        public class DepartmanDTO
        {
            public int DepartmanId { get; set; }
            public string DepartmanAd { get; set; }
        }
        public class RolDTO
        {
            public int RolId { get; set; }
            public string RolAd { get; set; }
        }
    }
}
