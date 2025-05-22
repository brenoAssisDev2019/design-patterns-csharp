using ReportBuilder.Abstractions.Interfaces;

namespace ReportBuilder.Abstractions
{
    public class ReportDirector
    {
        private readonly IReportBuilder _builder;

        public ReportDirector(IReportBuilder builder)
        {
            _builder = builder;
        }

        public Report Construct()
        {
            _builder.BuildHeader();
            _builder.BuildBody();
            _builder.BuildFooter();
            return _builder.GetReport();
        }
    }
}
