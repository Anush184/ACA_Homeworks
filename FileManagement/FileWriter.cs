using FileProcessing.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessing
{
    public class FileWriter
    {
        private readonly string _filePath;
        private readonly IFileLogger _fileLogger;

        public FileWriter(string filePath)
        {
            _filePath = filePath;   
            _fileLogger = new FileLogger();
        }

        public void WriteToFile(string text)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                _fileLogger.LogException(e);
            }
           
        }
        public void WriteAverageToFile(double average)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine("Average: " + average);
            }
        }
    }
}
