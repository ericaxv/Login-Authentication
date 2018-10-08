using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Presentation.Areas.AreaRestrita.Controllers
{
    public class DespesasController : Controller
    {
        // GET: AreaRestrita/Despesas
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Consulta()
        {
            return View();
        }
    }
}