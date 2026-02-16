namespace LLD.behavioral_design_patterns.Visitor
{
    public class DrawVisitor : IShapeVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("Drawing Circle");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
