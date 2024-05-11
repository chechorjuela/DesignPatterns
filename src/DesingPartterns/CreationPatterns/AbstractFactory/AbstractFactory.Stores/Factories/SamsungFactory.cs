using AbstractFactory.Stores.Devices;
using AbstractFactory.Stores.Products;

namespace AbstractFactory.Stores.Factories
{
    public class SamsungFactory : IElectronicProductFactory
    {
        public ILaptop CreateLaptop()
        {
            return new SamsungLaptop();
        }

        public IPhone CreatePhone()
        {
            return new SamsungPhone();
        }
    }
}