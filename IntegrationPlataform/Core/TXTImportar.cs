using Core.Data;
using Core.Models;

namespace Core;

public class TXTImportar
{
    static string Dados = File.ReadAllText(@$"{FilePath.PATH}\\testeTXT.txt");

    static string Genero;
    static string Categoria;
    static string Midia;
    static string TipoMidia;
    static string Classificacao;
    static string Participante;

    public static async Task Readtxt()
    {
        for (int i = 0; i < 20; i++)
        {
            Genero += Dados[i];
        }

        for (int i = 21; i <= 70; i++)
            Categoria += Dados[i];
        { }
        for (int i = 71; i <= 120; i++)
        {
            Midia += Dados[i];
        }
        for (int i = 121; i <= 170; i++)
        {
            TipoMidia += Dados[i];
        }
        for (int i = 171; i < 174; i++)
        {
            Classificacao += Dados[i];
        }
        for (int i = 174; i <= 273; i++)
        {
            Participante += Dados[i];
        }

        await TxtRepository.InserirAsync(
            new DataModel(Genero, Categoria, Midia, TipoMidia, Classificacao, Participante)
        );
    }
}
