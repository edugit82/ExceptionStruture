using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionStructure.Model
{
    public class ReportErrorsModel
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
    }
}
