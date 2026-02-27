namespace LLD.behavioral_design_patterns.Template
{
    public abstract class ReportGenerator
    {
        // Template Method
        public void GenerateReport()
        {
            FetchData();
            FormatData();
            SaveReport();
        }

        protected virtual void FetchData()
        {
            Console.WriteLine("Fetching common data...");
        }

        protected abstract void FormatData();

        protected virtual void SaveReport()
        {
            Console.WriteLine("Saving report to disk...");
        }
    }

}
