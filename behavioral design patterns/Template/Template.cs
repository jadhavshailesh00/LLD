namespace LLD.behavioral_design_patterns.Template
{
    internal class Template
    {
        public static void Run()
        {
            ReportGenerator pdf = new PdfReportGenerator();
            pdf.GenerateReport();

            Console.WriteLine();

            ReportGenerator excel = new ExcelReportGenerator();
            excel.GenerateReport();
        }
    }
}
