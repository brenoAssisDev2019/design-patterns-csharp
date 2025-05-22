namespace ReportBuilder.Abstractions.Interfaces
{
    public interface IReportBuilder
    {
        void BuildHeader();
        void BuildBody();
        void BuildFooter();
        Report GetReport();
    }
}
