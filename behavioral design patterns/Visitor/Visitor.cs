using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Visitor
{
    internal class Visitor
    {

        public void Run()
        {
            var shapes = new List<IShape>
{
    new Circle(5),
    new Rectangle(4, 6)
};

            var areaVisitor = new AreaVisitor();
            var drawVisitor = new DrawVisitor();

            foreach (var shape in shapes)
            {
                shape.Accept(areaVisitor);
                shape.Accept(drawVisitor);
            }
        }
    }
}
