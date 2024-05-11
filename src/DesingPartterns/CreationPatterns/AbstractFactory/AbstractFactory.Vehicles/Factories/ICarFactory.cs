using AbstractFactory.Vehicles.Vehicles;

namespace AbstractFactory.Vehicles.Factories
{
    public interface ICarFactory
    {
        ICar CreateCar();
    }
}