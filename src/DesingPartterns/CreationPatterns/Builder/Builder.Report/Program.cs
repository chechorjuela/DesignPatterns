// Crear un constructor de informes
using Builder.Reports.Builders;
using Builder.Reports.Models;

IReportBuilder reportBuilder = new ReportBuilder();

// Construir el informe
reportBuilder.BuildHeader();
reportBuilder.BuildBody();
reportBuilder.BuildFooter();

// Obtener el informe construido
Report report = reportBuilder.GetReport();

// Mostrar el informe
report.Display();