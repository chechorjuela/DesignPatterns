using AbstractFactory.Stores.Devices;

namespace AbstractFactory.Stores.Products
{
    public class SamsungLaptop : ILaptop
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Samsung Laptop: Galaxy Book Pro");
        }
    }
}