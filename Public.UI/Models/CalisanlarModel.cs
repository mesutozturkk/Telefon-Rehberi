using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelefonRehberi.ENT;
using static TelefonRehberi.BL.DTOS.DTOs;
using static TelefonRehberi.ENT.Entities;

namespace Public.UI.Models
{
    public class CalisanlarModel
    {
        public List<CalisanDTO> clist { get; set; }
        public Calisanlar Calisanlar { get; set; }
        public CalisanlarModel()
        {
            this.clist = new List<CalisanDTO>();
        }
    }
}