namespace LLD.behavioral_design_patterns.Template
{
    public class ExcelReportGenerator : ReportGenerator
    {
        protected override void FormatData()
        {
            Console.WriteLine("Formatting data as Excel...");
        }
    }
}
