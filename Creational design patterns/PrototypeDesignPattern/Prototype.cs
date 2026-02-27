namespace LLD.CreationalDesignPattern.PrototypeDesignPattern
{
    internal class Prototype
    {

        public static void ExecutePrototype()
        {
            Person Male1 = new Person { Name = "shailesh", Age = 30 };
            Person Male2 = Male1.Clone();
            Male2.Name = "Shailesh friend";

            Console.WriteLine(Male1); // Output: Name: shailesh, Age: 30
            Console.WriteLine(Male2); // Output: Name: shailesh friend, Age: 30

            Employee employee1 = new Employee { Name = "rahul", Age = 28, Position = "Developer" };
            Employee employee2 = employee1.Clone();
            employee2.Name = "Rahul V";
            employee2.Position = "Manager";

            Console.WriteLine(employee1); // Output: Name: rahul, Age: 28, Position: Developer
            Console.WriteLine(employee2); // Output: Name: Rahul V, Age: 28, Position: Manager


        }

    }
}
