using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Mediator
{
    public class User
    {
        private readonly IChatMediator _mediator;
        public string Name { get; }

        public User(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} receives: {message}");
        }
    }

}
