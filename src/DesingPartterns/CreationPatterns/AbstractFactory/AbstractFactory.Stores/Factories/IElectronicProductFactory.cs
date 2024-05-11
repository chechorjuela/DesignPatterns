using AbstractFactory.Stores.Devices;

namespace AbstractFactory.Stores.Factories
{
    public interface IElectronicProductFactory
    {
        IPhone CreatePhone();
        ILaptop CreateLaptop();
    }
}