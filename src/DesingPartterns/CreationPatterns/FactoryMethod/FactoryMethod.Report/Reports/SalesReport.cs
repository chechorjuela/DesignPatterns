namespace FactoryMethod.Reports.Reports
{
    public class SalesReport : Report
    {

        public override void GenerateReport()
        {
            PrintHeader();
            Console.WriteLine("Generating Sales Report...");
            PrintFooter();
        }
    }
}