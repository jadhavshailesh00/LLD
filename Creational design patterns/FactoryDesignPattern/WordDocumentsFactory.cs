namespace MyDSARepository.DesignPattern.CreationalDesignPattern.FactoryDesignPattern
{
    internal class WordDocumentsFactory : IDocumentFactory
    {
        public IDocument CreateDocuments()
        {
            return new WordDocument();
        }
    }
}
