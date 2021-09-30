using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap.Models
{
    public class infoPerson:Person
    {
        public string Sex { get; set; }
        [AllowHtml]
        public string Description { get; set; }
    }
}