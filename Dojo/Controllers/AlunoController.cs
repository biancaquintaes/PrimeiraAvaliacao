using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dojo.Controllers
{
    public class AlunoController : Controller
    {
        //
        // GET: /Aluno/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }
	}
}