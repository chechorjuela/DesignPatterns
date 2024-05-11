namespace AbstractFactory.Furniture.Furniture{
    public class ModernTable : ITable
    {
        public void Place()
        {
            Console.WriteLine("Placing something on a Modern table.");
        }
    }
}