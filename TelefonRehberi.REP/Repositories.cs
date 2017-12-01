using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TelefonRehberi.ENT.Entities;

namespace TelefonRehberi.REP
{
    public class Repositories
    {
        public class  CalisanRepository : BaseRepository<Calisanlar>
        {

        }
        public class KullaniciRepository : BaseRepository<Kullanicilar>
        {

        }
        public class DepartmanRepository : BaseRepository<Departman>
        {

        }
        public class RolRepository : BaseRepository<Roller>
        {

        }

    }
}
