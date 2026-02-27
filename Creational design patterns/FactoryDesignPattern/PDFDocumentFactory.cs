namespace MyDSARepository.DesignPattern.CreationalDesignPattern.FactoryDesignPattern
{
    internal class PDFDocumentFactory : IDocumentFactory
    {
        public IDocument CreateDocuments()
        {
            return new PDFDocuments();
        }
    }
}
