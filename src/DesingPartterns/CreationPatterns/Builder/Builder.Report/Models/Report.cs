namespace Builder.Reports.Models
{
    public class Report
    {
        public ReportHeader Header { get; set; }
        public ReportBody Body { get; set; }
        public ReportFooter Footer { get; set; }

        public void Display()
        {
            Console.WriteLine("***** Informe *****");
            Console.WriteLine($"Título: {Header.Title}");
            Console.WriteLine($"Fecha: {Header.Date}");
            Console.WriteLine($"Cuerpo: {Body.Content}");
            Console.WriteLine($"Autor: {Footer.Author}");
            Console.WriteLine("*******************");
        }
    }
}