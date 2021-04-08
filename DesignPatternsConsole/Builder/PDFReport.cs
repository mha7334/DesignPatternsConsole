namespace DesignPatternsConsole.Builder
{
    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.Content = "PDF Content Section";
        }
        public override void SetReportFooter()
        {
            reportObject.Footer = "PDF Footer";
        }
        public override void SetReportHeader()
        {
            reportObject.Header = "PDF Header";
        }
        public override void SetReportType()
        {
            reportObject.Type = "PDF";
        }
    }
}