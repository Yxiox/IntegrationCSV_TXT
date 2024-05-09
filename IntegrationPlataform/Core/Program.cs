using Core.Menus;
using Core.Txt;
using QuickKit.Cmd;
using QuickKit.Cmd.Enums;

var opcao = MainMenu.Mostrar();

switch (opcao)
{
    case 1:
        await TxtExporter.ExportAsync();
        break;
    case 2:
        break;
    case 3:
        break;
    case 4:
        break;
    default:
        Consoler.WriteLine("Opção inválida", AlertType.Warning);
        break;
}