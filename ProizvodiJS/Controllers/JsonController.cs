using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProizvodiJS.Models;
using Newtonsoft.Json;

namespace ProizvodiJS.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public ActionResult Index()
        {
            return View();

        }
        public JsonResult GetProizvod()
        {

            Proizvodi proizvod = new Proizvodi()
            {
                id = 1,
                naziv = "Cokolada",
                opis = "Mlecna",
                kategorija = "Slatkisi",
                proizvodjac = "Imlek",
                dobavljac = "doo.Beograd",
                cena = 200,


            };
            var json = JsonConvert.SerializeObject(proizvod);

            return Json(json, JsonRequestBehavior.AllowGet);

        }

    }
}