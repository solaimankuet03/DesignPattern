using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternBasic
{
    public class PdfReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Pdf Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Pdf Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Pdf Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }
}
