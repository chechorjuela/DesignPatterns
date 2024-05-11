using Builder.Reports.Models;

namespace Builder.Reports.Builders
{
    public class ReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public void BuildHeader()
        {
            // Lógica para construir el encabezado del informe
            _report.Header = new ReportHeader
            {
                Title = "Informe de Progreso",
                Date = DateTime.Now.ToShortDateString()
            };
        }

        public void BuildBody()
        {
            // Lógica para construir el cuerpo del informe
            _report.Body = new ReportBody
            {
                Content = "Este es el cuerpo del informe..."
            };
        }

        public void BuildFooter()
        {
            // Lógica para construir el pie de página del informe
            _report.Footer = new ReportFooter
            {
                Author = "John Doe"
            };
        }

        public Report GetReport()
        {
            return _report;
        }
    }
}