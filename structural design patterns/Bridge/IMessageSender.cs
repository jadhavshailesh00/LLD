using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Bridge
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
}
