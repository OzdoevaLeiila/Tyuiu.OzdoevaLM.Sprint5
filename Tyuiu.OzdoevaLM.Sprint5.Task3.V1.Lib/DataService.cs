using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.OzdoevaLM.Sprint5.Task3.V1.Lib;
public class DataService : ISprint5Task3V1
{
    public string SaveToFileTextData(int x)
    {
        string outputFile = "OutPutFileTask3.bin";

        string path = Path.Combine(Path.GetTempPath(), outputFile);

        FileInfo fileInfo = new(path);
        bool fileExists = fileInfo.Exists;
        if (fileExists) File.Delete(path);

        double y = Math.Round((Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)), 3);

        using (BinaryWriter writer = new(File.Open(path, FileMode.Append)))
        {
            writer.Write(y);
        }
        return path;
        throw new NotImplementedException();
    }
}
