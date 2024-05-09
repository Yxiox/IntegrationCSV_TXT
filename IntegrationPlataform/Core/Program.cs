// See https://aka.ms/new-console-template for more information
using Core.Csv;
using Core.Txt;
using Core.Shared;

await TxtExporter.ExportAsync();

CsvExporter csvExporter = new CsvExporter();

string caminhoArquivo = @$"C:\Users\valdi\Downloads/{Exporter.FILENAME_CSV}";
csvExporter.ExportToCsv(caminhoArquivo);

