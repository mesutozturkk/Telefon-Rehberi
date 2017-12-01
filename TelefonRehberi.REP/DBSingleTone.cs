using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.DAL;
using TelefonRehberi.ENT;

namespace TelefonRehberi.REP
{
    static public class DBSingleTone
    {
        static TelefonRehberiEntities db;
        static public TelefonRehberiEntities GetInstance()
        {
            if (db == null)
            {
                db = new TelefonRehberiEntities();
            }
            return db;
        }

    }
}
