using AbstractFactory.Stores.Devices;
using AbstractFactory.Stores.Products;

namespace AbstractFactory.Stores.Factories
{
    public class AppleFactory : IElectronicProductFactory
    {
        public IPhone CreatePhone()
        {
            return new SmartPhone();
        }

        public ILaptop CreateLaptop()
        {
            return new MacBook();
        }
    }

}