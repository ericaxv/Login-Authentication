using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Presentation.Areas.AreaRestrita.Controllers
{
    public class ReceitaController : Controller
    {
        // GET: AreaRestrita/Receita
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