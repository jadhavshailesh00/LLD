using MyDSARepository.DesignPattern.CreationalDesignPattern.BuilderDesignPattern;
using MyDSARepository.DesignPattern.CreationalDesignPattern.FactoryDesignPattern;
using MyDSARepository.DesignPattern.CreationalDesignPattern.PrototypeDesignPattern;
using MyDSARepository.DesignPattern.CreationalDesignPattern.SingletonDesignPattern;

namespace MyDSARepository.DesignPattern.CreationalDesignPattern
{
    internal class CreationDesignPatternMain : IRunnable
    {

        private static void FactoryDesignPatternExample()
        {
            Console.WriteLine("This is Factory Design Pattern example");
            Application pdf = new Application(new PDFDocumentFactory());
            pdf.OpenDocument();
            Console.ReadKey();
        }

        private static void SingleTonDesignPattern()
        {
            Console.WriteLine("This is signleton Design Pattern example");
            Logger logger = Logger.GetLogger();
            logger.GetLogManager();
        }

        private static void AbtractFactoryDesignPattern()
        {
            Console.WriteLine("This is AbtractFactory Design Pattern SBI example");
            var SBIObj = AbstractFactoryDesignPattern.AbstractFactoryDesignPattern.CreateFactory("SBI");
           var cc= SBIObj.CreateCCCard();
            cc.SwapCard();
            var atm=SBIObj.CreateATMCard();
            atm.SwapCard();
        }

        private static void PrototypeDesignPatternExample()
        {
            Console.WriteLine("This is Prototype Design Pattern example");
            Prototype.ExecutePrototype();
            Console.ReadKey();
        }

        private static void BuilderDesignPatternExample()
        {
            IAccountBuilder checkingBuilder = new CheckingAccountBuilder();
            AccountDirector director = new AccountDirector(checkingBuilder);
            director.OpenAccount();
            BankAccount checking = checkingBuilder.GetAccount();
            Console.WriteLine(checking);

            IAccountBuilder savingsBuilder = new SavingsAccountBuilder();
            director = new AccountDirector(savingsBuilder);
            director.OpenAccount();
            BankAccount savings = savingsBuilder.GetAccount();
            Console.WriteLine(savings);

            Console.ReadKey();
        }

        public void Run()
        {
            Console.WriteLine("Select a Creation Design Pattern to run:\n");

            Console.WriteLine("1. Factory Design Pattern Example");
            Console.WriteLine("2. SingleTon Design Pattern");
            Console.WriteLine("3. Abtract Factory Design Pattern");
            Console.WriteLine("4. Prototype Design Pattern");
            Console.WriteLine("5. Builder Design Pattern");

            if (int.TryParse(Console.ReadLine(), out int programChoice))
            {
                switch (programChoice)
                {
                    case 1:
                        CreationDesignPatternMain.SingleTonDesignPattern();
                        break;

                    case 2:
                        CreationDesignPatternMain.FactoryDesignPatternExample();
                        break;

                    case 3:
                        CreationDesignPatternMain.AbtractFactoryDesignPattern();
                        break;

                    case 4:
                        CreationDesignPatternMain.PrototypeDesignPatternExample();
                        break;

                    case 5:

                        CreationDesignPatternMain.BuilderDesignPatternExample();
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            Console.ReadKey();
        }
    }
}
