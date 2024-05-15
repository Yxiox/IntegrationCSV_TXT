using Core.Data;
using Core.Shared;

namespace Core.Txt;

internal class TxtExporter : Exporter
{
    public static async Task ExportAsync()
    {
        var data = await TxtRepository.ExportAll();

        foreach (var d in data)
        {
            StringHelper.AddSpaces(d.GENERO.Length, LengthData.GENERO, d.GENERO, _sb);
            StringHelper.AddSpaces(d.CATEGORIA.Length, LengthData.CATEGORIA, d.CATEGORIA, _sb);
            StringHelper.AddSpaces(d.MIDIA.Length, LengthData.MIDIA, d.MIDIA, _sb);
            StringHelper.AddSpaces(d.TIPO_MIDIA.Length, LengthData.TIPO_MIDIA, d.TIPO_MIDIA, _sb);
            StringHelper.AddSpaces(
                d.CLASSIFICACAO.Length,
                LengthData.CLASSIFICACAO,
                d.CLASSIFICACAO,
                _sb
            );
            StringHelper.AddSpaces(
                d.PARTICIPANTE.Length,
                LengthData.PARTICIPANTE,
                d.PARTICIPANTE,
                _sb
            );
            _sb.AppendLine();
        }

        var path = $"{FilePath.PATH}/{FILENAME_TXT}";

        Directory.CreateDirectory(FilePath.PATH);

        await File.Create(path).DisposeAsync();
        using (var sw = new StreamWriter(path))
        {
            await sw.WriteLineAsync(_sb.ToString());
        }
    }
}
