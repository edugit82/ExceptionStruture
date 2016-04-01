using System.Data.Entity.ModelConfiguration;
using Model.Model;

namespace DataAccess.Configuration
{
    public class ReportErrorsMap : EntityTypeConfiguration<ReportErrorsModel>
    {
        public ReportErrorsMap()
            : base()
        {
            HasKey(d => new { d.Id, d.DataHora });

            Property(p => p.Id).HasColumnName("Id");
            Property(p => p.DataHora).HasColumnName("Data_Hora");
            Property(p => p.Message).HasColumnName("Message");
            Property(p => p.Source).HasColumnName("Source");
            Property(p => p.StackTrace).HasColumnName("StackTrace");

            ToTable("dbo.Errors_Report");

        }
    }
}
