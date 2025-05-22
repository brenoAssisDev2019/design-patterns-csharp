using ReportBuilder.Abstractions.Interfaces;
using ReportBuilder.Abstractions;

namespace ReportBuilder.Builders
{
    public class PdfReportBuilder : IReportBuilder
    {
        private Report _report = new();

        public void BuildHeader()
        {
            _report.Header = "[PDF Report] Financial Report - 2025";
        }

        public void BuildBody()
        {
            _report.Body = "[PDF Report] Revenue: $1,000,000\nExpenses: $400,000";
        }

        public void BuildFooter()
        {
            _report.Footer = "[PDF Report] Confidential - All Rights Reserved.";
        }

        public Report GetReport() => _report;
    }
}
