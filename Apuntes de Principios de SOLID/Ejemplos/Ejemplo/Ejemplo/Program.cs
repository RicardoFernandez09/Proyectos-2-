using System;

class Report
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Report(string title, string content)
    {
        Title = title;
        Content = content;
    }
}

class ReportPrinter
{
    public void Print(Report report)
    {
        Console.WriteLine($"Título: Bank {report.Title}");
        Console.WriteLine($"Contenido: Dinero {report.Content}");
    }
}

class Program
{
    static void Main()
    {
        Report report = new Report("Informe mensual", "Pago del mes.");
        ReportPrinter printer = new ReportPrinter();
        printer.Print(report);
    }
}
