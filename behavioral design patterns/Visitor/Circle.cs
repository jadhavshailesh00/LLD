namespace LLD.behavioral_design_patterns.Visitor
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this); // double dispatch
        }
    }

}
