namespace LLD.behavioral_design_patterns.Visitor
{
    public class AreaVisitor : IShapeVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine($"Circle Area: {Math.PI * circle.Radius * circle.Radius}");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle Area: {rectangle.Width * rectangle.Height}");
        }
    }
}
