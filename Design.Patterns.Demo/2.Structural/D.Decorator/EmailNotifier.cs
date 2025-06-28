namespace Design.Patterns.Demo._2.Structural.D.Decorator
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }
}
