using Andino_Cristian_LPPA_Parcial1.Domain;
using Andino_Cristian_LPPA_Parcial1.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andino_Cristian_LPPA_Parcial1.Controllers
{
    [AllowAnonymous]
    public class AfiliadosController : Controller
    {
        // GET: Afiliados
        public ActionResult Index()
        {
            var biz = new AfiliadosBiz();
            var model = biz.Listar();
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var biz = new AfiliadosBiz();
            return View(biz.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Afiliados model)
        {
            var biz = new AfiliadosBiz();
            biz.Editar(model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var biz = new AfiliadosBiz();
            return View(biz.Get(id));
        }

        [HttpPost]
        public ActionResult Delete(Afiliados model)
        {
            var biz = new AfiliadosBiz();
            biz.Eliminar(model);
            return RedirectToAction("Index");
        }
    }
}