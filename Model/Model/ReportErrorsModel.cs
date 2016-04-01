using System;

namespace Model.Model
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
