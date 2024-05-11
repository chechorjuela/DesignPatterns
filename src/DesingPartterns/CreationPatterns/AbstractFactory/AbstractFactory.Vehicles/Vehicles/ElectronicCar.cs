namespace AbstractFactory.Vehicles.Vehicles
{
    public class ElectronicCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving a electronic car...");
        }
    }
}