namespace DesignPatternsConsole.Builder
{
    class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.Content = "Excel Content Section";
        }
        public override void SetReportFooter()
        {
            reportObject.Footer = "Excel Footer";
        }
        public override void SetReportHeader()
        {
            reportObject.Header = "Excel Header";
        }
        public override void SetReportType()
        {
            reportObject.Type = "Excel";
        }
    }
}