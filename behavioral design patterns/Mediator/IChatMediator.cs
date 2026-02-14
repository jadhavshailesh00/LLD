using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Mediator
{
    public interface IChatMediator
    {
        void SendMessage(string message, User sender);
        void RegisterUser(User user);
    }
}
