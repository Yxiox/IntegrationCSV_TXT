using System.Text;

namespace Integration.Core.Shared;

internal abstract class Exporter
{
    protected static readonly StringBuilder _sb = new();
    protected const string FILENAME_TXT = "ImporterTxt.txt";
    public const string FILENAME_CSV = "ImporterCsv.csv";
}
