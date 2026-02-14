using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Mediator
{
    public class Mediator
    {

        public static void Run()
        {
            var mediator = new ChatMediator();

            var user1 = new User("Alice", mediator);
            var user2 = new User("Bob", mediator);
            var user3 = new User("Charlie", mediator);

            mediator.RegisterUser(user1);
            mediator.RegisterUser(user2);
            mediator.RegisterUser(user3);

            user1.Send("Hello everyone!");
        }
    }
}
