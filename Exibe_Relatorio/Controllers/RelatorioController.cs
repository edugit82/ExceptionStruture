using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Context;
using Model.Model;
using Model.ViewModel;

namespace Exibe_Relatorio.Controllers
{
    public class RelatorioController : Controller
    {
        //
        // GET: /Relatorio/

        public ActionResult Index()
        {
            var viewmodel = new RelatorioViewModel();
            using(var context = new ReportErrorsContext())
            {
                var dados = context.ReportErrors
                            .OrderByDescending(x => x.Id)
                            .ThenBy(x => x.DataHora)
                            .ToList();
                
                viewmodel.ListaErros.AddRange(dados);
            };
            
            return View(viewmodel);
        }

    }
}
