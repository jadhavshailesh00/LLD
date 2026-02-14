using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Mediator
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new();

        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.Receive(message);
                }
            }
        }
    }
}
