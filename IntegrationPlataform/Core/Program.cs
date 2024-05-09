// See https://aka.ms/new-console-template for more information
using Core.Csv;
using Core.Data;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var csvExporter = new CsvExporter(Repository.CONNECTION_STRING_V);
        string caminhoArquivo = @"C:\\Users\\valdi\\Downloads\dadosbancoCsv.csv";
        csvExporter.ExportToCsv(caminhoArquivo);
    }
}