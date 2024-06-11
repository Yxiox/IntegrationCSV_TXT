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


        int count = 0;
        int count2 = 0;
        while (count2 != Dados.Length)
        {
            Genero = "";
            for (int i = count; i < count2 + 20; i++)
            {
                Genero += Dados[i];
                count += 1;
            }
            count2 += 20;
            
            Categoria = "";
            for (int i = count; i < count2 + 50; i++)
            {
                Categoria += Dados[i];
                count += 1;
            }
            count2 += 50;

            Midia = "";
            for (int i = count; i < count2 + 50; i++)
            {
                Midia += Dados[i];
                count += 1;
            }
            count2 += 50;

            TipoMidia = "";
            for (int i = count; i < count2 + 50; i++)
            {
                TipoMidia += Dados[i];
                count += 1;

            }
            count2 += 50;

            Classificacao = "";
            for (int i = count; i < count2 + 3; i++)
            {
                Classificacao += Dados[i];
                count += 1;
            }
            count2 += 3;

            Participante = "";
            for (int i = count; i < count2+100; i++)
            {
                Participante += Dados[i];
                count += 1;
            }
            count2 += 100;
            await TxtRepository.InserirAsync(new DataModel(Genero, Categoria, Midia, TipoMidia, Classificacao, Participante));

        }

    }
}