namespace FactoryMethod.Reports.Reports
{
    public class InventoryReport : Report
    {
        public override void GenerateReport()
        {
            PrintHeader();
            Console.WriteLine("Generating Inventory Report...");
            PrintFooter();
        }
    }
}