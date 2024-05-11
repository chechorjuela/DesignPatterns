using FactoryMethod.Reports.Reports;

namespace FactoryMethod.Reports.Factories
{
    public class ReportFactory
    {
        public static IReport CreateReport(string reportType)
        {
            switch (reportType.ToLower())
            {
                case "sales":
                    return new SalesReport();
                    break;
                case "financial":
                    return new FinancialReport();
                    break;
                case "inventory":
                    return new InventoryReport();
                    break;
                default:
                    throw new ArgumentException("Invalid Report type");
            }
        }
    }

}