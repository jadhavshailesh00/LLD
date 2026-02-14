using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Visitor
{
    public interface IShape
    {
        void Accept(IShapeVisitor visitor);
    }
}
