using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static TelefonRehberi.BL.DTOS.DTOs;
using static TelefonRehberi.ENT.Entities;

namespace Admin.UI.Models
{
    public class DepartmanModel
    {
        public Departman Departman { get; set; }
        public List<DepartmanDTO> dlist { get; set; }
    }
}