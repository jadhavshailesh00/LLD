namespace LLD.CreationalDesignPattern.PrototypeDesignPattern
{
    public class Person : IPrototype<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person Clone()
        {
            return (Person)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Name is :" + Name + "Age is :" + Age;
        }
    }
}
