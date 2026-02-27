namespace LLD.behavioral_design_patterns.Template
{
    public class PdfReportGenerator : ReportGenerator
    {
        protected override void FormatData()
        {
            Console.WriteLine("Formatting data as PDF...");
        }
    }

}
