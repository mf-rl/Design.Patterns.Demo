namespace Design.Patterns.Demo._2.Structural.G.Proxy
{
    public class RealImage : IImage
    {
        private string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading {_filename} from disk...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_filename}");
        }
    }
}
