namespace LLD.structural_design_patterns.Bridge
{
    public class UrgentNotification : Notification
    {
        public UrgentNotification(IMessageSender messageSender)
            : base(messageSender) { }

        public override void Send(string message)
        {
            _messageSender.SendMessage("URGENT: " + message);
        }
    }
}
