using ReportBuilder.Abstractions.Interfaces;
using ReportBuilder.Abstractions;
using ReportBuilder.Builders;

Console.WriteLine("--- Gerador de Relatórios ---\n");

var builders = new (string Nome, IReportBuilder Builder)[]
{
                ("PDF", new PdfReportBuilder()),
                ("Excel", new ExcelReportBuilder()),
                ("JSON", new JsonReportBuilder())
};

foreach (var (nome, builder) in builders)
{
    Console.WriteLine($"Relatório no formato {nome}:");
    var director = new ReportDirector(builder);
    var report = director.Construct();
    Console.WriteLine(report);
    Console.WriteLine("\n----------------------------\n");
}