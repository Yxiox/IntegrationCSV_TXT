using QuickKit.Cmd;
using QuickKit.Cmd.Enums;

namespace Integration.Core.Menus;

internal class MainMenu
{
    public static int Mostrar()
    {
        int opcao = 0;
        List<int> opcoes = new List<int> { 1, 2, 3, 4 };
        do
        {
            Consoler.WriteLine("---------------MENU PRINCIPAL---------------");

            Consoler.WriteLine("1 - Exportar TXT");
            Consoler.WriteLine("2 - Importar TXT");

            Consoler.WriteLine("3 - Exportar CSV");
            Consoler.WriteLine("4 - Importar CSV");

            opcao = int.Parse(Consoler.ReadLine("Informe um valor válido"));

            if (!opcoes.Contains(opcao))
            {
                Consoler.WriteLine("Digite uma opção válida", AlertType.Warning);
            }
            else
            {
                break;
            }
        } while (true);
        return opcao;
    }
}
