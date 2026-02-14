namespace LLD.behavioral_design_patterns.Visitor
{
    public interface IShape
    {
        void Accept(IShapeVisitor visitor);
    }
}
