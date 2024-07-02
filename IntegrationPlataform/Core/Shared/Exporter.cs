using System.Text;

namespace Core.Shared;

internal abstract class Exporter
{
    protected readonly static StringBuilder _sb = new();
    protected const string FILENAME_TXT = "ImporterTxt.txt";
    public const string FILENAME_CSV = "ImporterCsv.csv";
}
