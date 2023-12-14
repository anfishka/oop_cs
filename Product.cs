class Program
{

    public class Key
    {
        public string LockType { get; set; }
        public string Compatibility { get; set; }
        public string Brand { get; set; }
        public string ManufacturingСountry { get; set; }
        public float Width { get; set; }

        public float Heigth { get; set; }

        public int Waranty { get; set; }
        public float Price { get; set; }
        public string Color { get; set; }

        public Key(string lockType, string compatibility, string brand, string manufacturingСountry, float width, float heigth, int waranty, float price, string color)
        {
            this.LockType = lockType;
            this.Compatibility = compatibility;
            this.Brand = brand;
            this.ManufacturingСountry = manufacturingСountry;
            this.Width = width;
            this.Heigth = heigth;
            this.Waranty = waranty;
            this.Price = price;
            this.Color = color;
        }
    }


    class Lock
    {

    }


    static void Main(string[] args)
    {

        Key demoKey = new Key("Cylinder Lock", "Standard", "ABC Company", "Ireland", 6.0f, 4.0f, 12, 100.5f, "Silver");

        Console.WriteLine($"LockType: {demoKey.LockType}");
        Console.WriteLine($"Compatibility: {demoKey.Compatibility}");
        Console.WriteLine($"Brand: {demoKey.Brand}");
        Console.WriteLine($"ManufacturingСountry: {demoKey.ManufacturingСountry}");
        Console.WriteLine($"Size (width: {demoKey.Width}, height: {demoKey.Heigth})");
        Console.WriteLine($"Waranty: {demoKey.Waranty} months");
        Console.WriteLine($"Price: {demoKey.Price} grn");
        Console.WriteLine($"Color: {demoKey.Color}");
    }


 }
