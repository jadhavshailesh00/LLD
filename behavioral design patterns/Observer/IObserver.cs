using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Observer
{
    public interface IObserver
    {
        void Update(decimal price);
    }
}
