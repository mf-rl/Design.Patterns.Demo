namespace Design.Patterns.Demo._2.Structural
{
    public static class ProxyExample
    {
        public static void Run()
        {
            IImage image = new ProxyImage("test_image.jpg");

            // Image will be loaded and displayed
            image.Display();

            // Image will be displayed directly (no loading)
            image.Display();
        }
    }
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _filename;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.Display();
        }
    }
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
    public interface IImage
    {
        void Display();
    }
}
