using FactoryMethod.Reports.Factories;
using FactoryMethod.Reports.Reports;

IReport saleReport = ReportFactory.CreateReport("Sales");
saleReport.GenerateReport();

IReport inventoryReport = ReportFactory.CreateReport("inventory");
inventoryReport.GenerateReport();

IReport finanicalReport = ReportFactory.CreateReport("financial");
finanicalReport.GenerateReport();