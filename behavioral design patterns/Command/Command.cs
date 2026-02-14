namespace LLD.behavioral_design_patterns.Command
{
    public class Command
    {
        public static void Run()
        {
            var light = new Light();

            var turnOn = new TurnOnCommand(light);
            var turnOff = new TurnOffCommand(light);

            var remote = new RemoteControl();

            remote.SetCommand(turnOn);
            remote.PressButton();
            remote.PressUndo();

        }
    }
}
