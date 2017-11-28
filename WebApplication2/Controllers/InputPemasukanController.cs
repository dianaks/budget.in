using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class InputPemasukanController : Controller
    {
        // GET: InputPemasukan
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(InputPemasukan inputPemasukan)
        {
            int pemasukan = inputPemasukan.PemasukanPerBulan;

            return View();
        }
    }
}