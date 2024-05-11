using Builder.Reports.Models;

namespace Builder.Reports.Builders
{
    public interface IReportBuilder
    {
        void BuildHeader();
        void BuildBody();
        void BuildFooter();
        Report GetReport();
    }
}