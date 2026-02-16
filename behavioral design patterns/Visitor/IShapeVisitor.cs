namespace LLD.behavioral_design_patterns.Visitor
{
    public interface IShapeVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
    }
}
