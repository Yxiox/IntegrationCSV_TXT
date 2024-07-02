using Integration.Core.Data;
using Integration.Core.Models;

namespace Integration.Core;

public class TXTImportar
{
    public static async Task Readtxt()
    {
        Directory.CreateDirectory(FilePath.PATH);
        await TxtRepository.Delete();

        string genero = "";
        string categoria = "";
        string midia = "";
        string tipoMidia = "";
        string classificacao = "";
        string participante = "";

        using (StreamReader sr = File.OpenText(@$"{FilePath.PATH}\\ImporterTxt.txt"))
        {
            string s = string.Empty;
            while ((s = sr.ReadLine()) != null)
            {
                //await Console.Out.WriteLineAsync(s);
                for (int i = 0; i < 20; i++)
                {
                    genero += s[i];
                }

                for (int i = 20; i < 70; i++)
                {
                    categoria += s[i];
                }
                for (int i = 70; i < 120; i++)
                {
                    midia += s[i];
                }
                for (int i = 120; i < 170; i++)
                {
                    tipoMidia += s[i];
                }
                for (int i = 170; i < 173; i++)
                {
                    classificacao += s[i];
                }
                for (int i = 173; i < 273; i++)
                {
                    participante += s[i];
                }

                await TxtRepository.InserirAsync(new DataModel(genero, categoria, midia, tipoMidia, classificacao, participante));

                genero = "";
                categoria = "";
                midia = "";
                tipoMidia = "";
                classificacao = "";
                participante = "";
            }
        }
    }
}