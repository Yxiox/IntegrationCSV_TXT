// See https://aka.ms/new-console-template for more information
using Core;

Console.WriteLine("Hello, World!");
TXTImportar txt = new();

txt.readtxt();
using Core.Txt;

Console.WriteLine("Hello, World!");


await TxtExporter.ExportAsync();
