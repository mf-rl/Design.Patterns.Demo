namespace Design.Patterns.Demo._3.Behavioral.B.Command
{
    public static class CommandExample
    {
        public static void Run()
        {
            var light = new Light();
            var turnOn = new TurnOnCommand(light);
            var turnOff = new TurnOffCommand(light);

            var remote = new RemoteControl();

            remote.SetCommand(turnOn);
            remote.PressButton();

            remote.SetCommand(turnOff);
            remote.PressButton();
        }
    }
}
