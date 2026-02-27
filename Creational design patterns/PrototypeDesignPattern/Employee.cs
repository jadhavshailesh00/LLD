namespace MyDSARepository.DesignPattern.CreationalDesignPattern.PrototypeDesignPattern
{
    internal class Employee : Person
    {
        public string Position { get; set; }
        public new Employee Clone()
        {
            return (Employee)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Name is :" + Name + "Age is :" + Age + "The position is :" + Position;
        }
    }
}
