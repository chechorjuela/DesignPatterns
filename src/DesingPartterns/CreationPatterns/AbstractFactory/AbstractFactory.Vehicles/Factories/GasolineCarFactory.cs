using AbstractFactory.Vehicles.Vehicles;

namespace AbstractFactory.Vehicles.Factories{
    public class GasolineCarFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new gasolineCar();
        }
    }
}