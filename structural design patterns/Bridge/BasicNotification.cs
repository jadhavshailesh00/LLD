namespace LLD.structural_design_patterns.Bridge
{
    public class BasicNotification : Notification
    {
        public BasicNotification(IMessageSender messageSender)
            : base(messageSender) { }

        public override void Send(string message)
        {
            _messageSender.SendMessage(message);
        }
    }
}
