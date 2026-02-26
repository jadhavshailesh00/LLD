using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Bridge
{
    public class Bridge
    {
        public static void Run()
        {
            IMessageSender emailSender = new EmailSender();
            IMessageSender smsSender = new SmsSender();

            Notification notification1 = new BasicNotification(emailSender);
            notification1.Send("Hello World");

            Notification notification2 = new UrgentNotification(smsSender);
            notification2.Send("Server is down!");
        }
    }
}
