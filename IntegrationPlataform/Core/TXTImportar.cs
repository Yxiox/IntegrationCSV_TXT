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
        Directory.CreateDirectory(FilePath.PATH);

        for (int i = 0; i < 20; i++)
        {
            Genero += Dados[i];
        }

        for (int i = 20; i < 70; i++)
            Categoria += Dados[i];
        {
        }
        for (int i = 70; i < 120; i++)
        {
            Midia += Dados[i];
        }
        for (int i = 120; i < 170; i++)
        {
            TipoMidia += Dados[i];
        }
        for (int i = 170; i < 173; i++)
        {
            Classificacao += Dados[i];
        }
        for (int i = 173; i < 273; i++)
        {
            Participante += Dados[i];
        }

        await TxtRepository.InserirAsync(new DataModel(Genero, Categoria, Midia, TipoMidia, Classificacao, Participante));
    }
}