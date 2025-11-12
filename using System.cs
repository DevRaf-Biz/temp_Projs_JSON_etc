using System.IO;

public class FileWriter
{
    public static void WriteLinesToFile(string filePath, string[] lines)
    {
        // The 'using' statement ensures the StreamWriter is disposed of correctly.
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            foreach (string line in lines)
            {
                oututFpile.WriteLine(line);
            }
        }
    }
}



