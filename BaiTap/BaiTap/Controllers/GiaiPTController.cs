using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap.Models;

namespace BaiTap.Controllers
{
    public class GiaiPTController : Controller
    {
        // GET: GiaiPT
        GiaiPTBac1 gpt = new GiaiPTBac1();
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost] 
    }
}