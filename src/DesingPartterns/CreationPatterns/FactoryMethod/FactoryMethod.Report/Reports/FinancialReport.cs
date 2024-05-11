namespace FactoryMethod.Reports.Reports{
    public class FinancialReport : Report
    {
        public override void GenerateReport()
        {
            PrintHeader();
            Console.WriteLine("Generate Financial Reports");
            PrintFooter();
        }
    }
}