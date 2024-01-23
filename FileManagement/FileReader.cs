using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessing
{
    class FileReader
{
    private readonly string filePath;

    public FileReader(string filePath)
    {
        this.filePath = filePath;
    }

    public List<string> ReadLinesFromFile()
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"The file {filePath} was not found.");

        List<string> numbers = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            
            while ((line = reader.ReadLine()) != null)
            { 
                numbers.Add(line);
            }
        }

        return numbers;
    }
}

}
