using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternBasic
{
    public abstract class ReportBuilder
    {
        protected Report reportObject = null;

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateReport()
        {
            reportObject = new Report();
        }

        public Report GetReport()
        {
            return reportObject;
        }
    }
}
