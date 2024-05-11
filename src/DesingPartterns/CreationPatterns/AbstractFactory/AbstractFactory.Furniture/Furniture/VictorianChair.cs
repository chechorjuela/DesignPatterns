namespace AbstractFactory.Furniture.Furniture
{
    public class VictorianChair : IChair
    {
        public void Sit()
        {
            Console.WriteLine("Sitting on a Victorian chair.");
        }
    }
}