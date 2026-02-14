namespace LLD.behavioral_design_patterns.Mediator
{
    public interface IChatMediator
    {
        void SendMessage(string message, User sender);
        void RegisterUser(User user);
    }
}
