using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Visitor
{
    public interface IShapeVisitor
    {
        void Visit(Circle circle);
        void Visit(Rectangle rectangle);
    }
}
