using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using DataAccess.Configuration;
using Model.Model;

namespace DataAccess.Context
{
    public class ReportErrorsContext : DbContext
    {
        public ReportErrorsContext()
            : base("ReportErrorsContext")
        {
            var split = AppDomain.CurrentDomain.BaseDirectory.Split('\\').ToList();
            split.RemoveRange(split.Count - 2, 2);
            var path = String.Join(@"\", split);

            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }
        public DbSet<ReportErrorsModel> ReportErrors { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ReportErrorsMap());
        }
    }
}
