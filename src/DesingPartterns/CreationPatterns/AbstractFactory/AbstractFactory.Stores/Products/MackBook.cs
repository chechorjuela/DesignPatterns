using AbstractFactory.Stores.Devices;

namespace AbstractFactory.Stores.Products
{
    public class MacBook : ILaptop
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Apple Laptop: MacBook Pro");
        }
    }

}
