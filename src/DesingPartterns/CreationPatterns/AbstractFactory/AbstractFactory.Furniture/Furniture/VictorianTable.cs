namespace AbstractFactory.Furniture.Furniture{
    public class VictorianTable : ITable
    {
        public void Place()
        {
            Console.WriteLine("Placing something on a Victorian table.");
        }
    }
}