using AbstractFactory.Stores.Devices;

namespace AbstractFactory.Stores.Products
{
    public class SmartPhone : IPhone
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Apple Phone: iPhone 12");
        }
    }

}
