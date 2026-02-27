namespace MyDSARepository.DesignPattern.CreationalDesignPattern.FactoryDesignPattern
{
    internal class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Open word document");
        }
    }
}
