namespace ReportBuilder.Abstractions
{
    public class Report
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        public override string ToString() =>
            $"HEADER:\n{Header}\n\nBODY:\n{Body}\n\nFOOTER:\n{Footer}";
    }
}
