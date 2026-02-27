namespace LLD.CreationalDesignPattern.FactoryDesignPattern
{
    internal class PDFDocuments : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document");
        }
    }
}
