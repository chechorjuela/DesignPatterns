using AbstractFactory.Vehicles.Vehicles;

namespace AbstractFactory.Vehicles.Factories
{
    public class ElectricCarFactory : ICarFactory
    {
        public ICar CreateCar()
        {
           return new ElectronicCar();
        }
    }
}