namespace AbstractFactory.Vehicles.Vehicles
{
    public class gasolineCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving a gasoline car...");
        }
    }
}