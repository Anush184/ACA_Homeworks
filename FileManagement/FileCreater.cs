using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessing
{
    public class CreateFile
    {
        public static string CreateOrUpdateFile(string fileName)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            if (File.Exists(filePath))
            {
                Console.WriteLine($"File '{fileName}' already exists at: {filePath}");
            }
            else
            {
                // Get the directory part of the path
                string directoryPath = Path.GetDirectoryName(filePath);

                // Check if the directory exists, and create it if not
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Create an empty file
                File.Create(filePath).Close();
                Console.WriteLine($"File '{fileName}' created at: {filePath}");
            }

            return filePath;
        }

    }
}
