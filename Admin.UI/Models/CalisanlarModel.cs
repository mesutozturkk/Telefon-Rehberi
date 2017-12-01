using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelefonRehberi.ENT;
using static TelefonRehberi.BL.DTOS.DTOs;
using static TelefonRehberi.ENT.Entities;

namespace Admin.UI.Models
{
    public class CalisanlarModel
    {
        public List<CalisanDTO> clist { get; set; }
        public Calisanlar Calisanlar { get; set; }
        public CalisanlarModel()
        {
            this.clist = new List<CalisanDTO>();
        }
        public List<SelectListItem> YöneticiForDropDown { get; set; }
        public List<SelectListItem> DepartmanForDropDown { get; set; }
    }
}