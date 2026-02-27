namespace MyDSARepository.DesignPattern.StructuralDesignPattern.RepositoryDesignPattern
{
    public class Controller
    {
        IRepository _repository;
        public Controller(IRepository repository)
        {
            _repository = repository;
        }

        public void BackEndLogic()
        {
            _repository.BackEndDisplayLogic();
        }

        public void FrontEndLogic()
        {
            Console.WriteLine("This is UI logic");
        }
    }
}
