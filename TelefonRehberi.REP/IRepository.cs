using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi.REP
{
    public interface IRepository<T> where T : class, new()
    {

        DbSet<T> Set();
        List<T> Listele();
        void Sil(T entity);
        void Guncelle(T entity);
        void Ekle(T entity);
        T Bul(int id);
        T Bul(string id);
        void Save();
        IQueryable<T> GenelListe();
    }
}
