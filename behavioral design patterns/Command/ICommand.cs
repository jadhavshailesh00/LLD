namespace LLD.behavioral_design_patterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
