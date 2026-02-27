namespace LLD.CreationalDesignPattern.FactoryDesignPattern
{
    internal class Application
    {
        IDocumentFactory documentFactory;
        public Application(IDocumentFactory documentFactory)
        {
            this.documentFactory = documentFactory;
        }

        public void OpenDocument()
        {
            IDocument document = documentFactory.CreateDocuments();
            document.Open();
        }
    }
}
