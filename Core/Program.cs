using Core;
using Core.Csv;
using Core.Menus;
using Core.Txt;
using QuickKit.Cmd;
using QuickKit.Cmd.Enums;

Directory.CreateDirectory(FilePath.PATH);
var opcao = MainMenu.Mostrar();

switch (opcao)
{
    case 1:
        await TxtExporter.ExportAsync();
        break;
    case 2:
        await TXTImportar.Readtxt();
        break;
    case 3:
        CsvExporter.ExportToCsv();
        break;
    case 4:
        await CsvImporter.Import();
        break;
    default:
        Consoler.WriteLine("Opção inválida", AlertType.Warning);
        break;
}
