// See https://aka.ms/new-console-template for more information
using Core.Csv;
using Core.Data;
using Core.Txt;
using System.Data;

var csvExporter = new CsvExporter(Repository.CONNECTION_STRING_V);
string caminhoArquivo = @"C:\\Users\\valdi\\Downloads\dadosbancoCsv.csv";
csvExporter.ExportToCsv(caminhoArquivo);



await TxtExporter.ExportAsync();
