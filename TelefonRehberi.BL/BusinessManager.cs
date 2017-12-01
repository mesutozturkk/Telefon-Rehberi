using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TelefonRehberi.BL.DTOS.DTOs;
using static TelefonRehberi.ENT.Entities;
using static TelefonRehberi.REP.Repositories;

namespace TelefonRehberi.BL
{
    public class BusinessManager
    {
        public class CalisanManager : CalisanRepository
        {
            public List<CalisanDTO> CalisanListele()
            {
                return GenelListe().Select(x => new CalisanDTO
                {
                    CalisanAd = x.CalisanAd,
                    CalisanId = x.CalisanId,
                    CalisanSoyad = x.CalisanSoyad,
                    CalisanTelefon = x.CalisanTelefon,
                    DepartmanId = x.DepartmanId,
                    YöneticiId=x.YöneticiId
                }).ToList();
            }

        }
        public class KullaniciManager : KullaniciRepository
        {
            public KullaniciDTO Denetle(string UserId, string sifre)
            {
                Kullanicilar kullanici = null;
                kullanici = Bul(UserId);
                if (kullanici != null)
                {
                    if (kullanici.Sifre == sifre)
                    {
                        KullaniciDTO kullaniciDTO = new KullaniciDTO();
                        kullaniciDTO.UserId = kullanici.UserId;
                        kullaniciDTO.RolAd = kullanici.Roller.RolAd;
                        kullaniciDTO.CalisanAd = kullanici.Calisanlar.CalisanAd + " " + kullanici.Calisanlar.CalisanSoyad;
                        return kullaniciDTO;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            public bool SifreDegistir(string UserId, string eskiSifre, string yeniSifre)
            {
                Kullanicilar kullanici = Bul(UserId);
                if (kullanici.Sifre == eskiSifre)
                {
                    kullanici.Sifre = yeniSifre;
                    Save();
                    return true;
                }
                else return false;
            }

        }
        public class DepartmanManager : DepartmanRepository
        {
            public string DepartmanSil(int depID)
            {
                
                Departman departman = Bul(depID);
                CalisanManager cm = new CalisanManager();
                int sonuc=cm.GenelListe().Where(x => x.DepartmanId == depID).Count();
                if (sonuc==0)
                {
                    Sil(departman);
                    Save();
                    return  "Departman başarıyla silindi";
                }
                else
                {
                    return "Departmanda " + sonuc + " adet kayıt olduğundan departman silinemez";
                }
            }

            public List<DepartmanDTO> DepartmanListele()
            {
                return GenelListe().Select(x => new DepartmanDTO
                {
                   DepartmanId=x.DepartmanId,
                   DepartmanAd=x.DepartmanAd
                }).ToList();
            }
        }
        public class RolManager : RolRepository
        {

        }
    }
}
