namespace FactoryMethod.Reports.Reports
{
    public abstract class Report : IReport
    {
        public abstract void GenerateReport();
        // Método compartido para todos los informes
        protected void PrintHeader()
        {
            Console.WriteLine("=== Report Header ===");
        }

        // Método compartido para todos los informes
        protected void PrintFooter()
        {
            Console.WriteLine("=== Report Footer ===");
        }
    }
}