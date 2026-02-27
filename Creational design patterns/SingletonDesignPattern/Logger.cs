namespace LLD.CreationalDesignPattern.SingletonDesignPattern
{
    internal class Logger
    {
        private static Logger Instance;
        private Logger()
        {

        }

        public static Logger GetLogger()
        {
            if (Instance == null)
            {
                Instance = new Logger();
            }
            return Instance;
        }

        public void GetLogManager()
        {
            Console.WriteLine("This is Log of" + Instance);
        }
    }

}
