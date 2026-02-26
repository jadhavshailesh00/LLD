using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Bridge
{
    public abstract class Notification
    {
        protected IMessageSender _messageSender;

        protected Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public abstract void Send(string message);
    }
}
