using AbstractFactory.Stores.Devices;

namespace AbstractFactory.Stores.Products{
    public class SamsungPhone : IPhone
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Samsung Phone: Galaxy S21");
        }
    }
}