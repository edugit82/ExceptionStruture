using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Model;

namespace Model.ViewModel
{
    public class RelatorioViewModel
    {
        public RelatorioViewModel()
        {
            this.ListaErros = new List<ReportErrorsModel>();
        }
        public List<ReportErrorsModel> ListaErros { get; set; }
    }
}
