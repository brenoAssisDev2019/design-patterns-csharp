using ReportBuilder.Abstractions.Interfaces;
using ReportBuilder.Abstractions;

namespace ReportBuilder.Builders
{
    public class ExcelReportBuilder : IReportBuilder
    {
        private Report _report = new();

        public void BuildHeader()
        {
            _report.Header = "[Excel Report] Financial Report - Columns Setup";
        }

        public void BuildBody()
        {
            _report.Body = "[Excel Report] | Month | Revenue | Expenses |\n| Jan | $100K | $40K |";
        }

        public void BuildFooter()
        {
            _report.Footer = "[Excel Report] Generated using Excel SDK";
        }

        public Report GetReport() => _report;
    }
}
