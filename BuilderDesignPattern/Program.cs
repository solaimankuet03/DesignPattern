using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report;
            ReportDirector reportDirector = new ReportDirector();
            // Construct and display Reports
            PdfReport pdfReport = new PdfReport();
            //ReportBuilder pdfReport = new PdfReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            Console.WriteLine("-------------------");
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();

        }
    }
}
