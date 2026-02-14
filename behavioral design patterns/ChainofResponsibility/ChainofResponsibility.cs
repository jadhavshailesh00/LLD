using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.ChainofResponsibility
{
    public class ChainofResponsibility
    {

        public static void Run()
        {
            var manager = new Manager();
            var director = new Director();
            var ceo = new CEO();
            manager.SetNext(director);
            director.SetNext(ceo);
            manager.HandleRequest(7000);

        }
    }
}
