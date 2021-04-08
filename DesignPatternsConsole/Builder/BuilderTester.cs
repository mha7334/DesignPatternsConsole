using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.Builder
{
    public static class BuilderTester
    {
        public static void Run()
        {
            Report report;
            ReportDirector reportDirector = new ReportDirector();
            // Construct and display Reports
            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.Display();
            Console.WriteLine("-------------------");
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.Display();

        }
    }
}
