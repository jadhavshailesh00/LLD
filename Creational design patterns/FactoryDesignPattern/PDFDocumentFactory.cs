namespace LLD.CreationalDesignPattern.FactoryDesignPattern
{
    internal class PDFDocumentFactory : IDocumentFactory
    {
        public IDocument CreateDocuments()
        {
            return new PDFDocuments();
        }
    }
}
