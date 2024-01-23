using Microsoft.Extensions.Logging;
using System.IO;
using System;
using FileProcessing.Interface;

namespace FileProcessing
{
    class DataProcessor
    {
        private readonly IFileLogger _logger;
        public DataProcessor(IFileLogger logger)
        {
            _logger = logger;
        }
        public double CalculateAverage(List<string> lines)
        {
            if (lines.Count == 0)
                return 0; 

            int sum = 0;
            int count = 0;
            foreach (string line in lines)
            {
                for (int i = 0; i < line.Length; i++ )
                {
                    
                    if (int.TryParse(line.Substring(i,1), out int number))
                    {
                        sum += number;
                        count++;
                    }
                    
                }

            }

            if (sum == 0)
            {
                return 0;
               HandleException(new ArgumentException(), "input.txt not found.");
            }
            
            return (double)sum / count;
        }
        public string CreateFile(string file)
        {
           string newFile =  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), file);
           return newFile;
        }

        public void ProcessData(string inputFile, string outputfile)
        {
            try
            {
                FileReader fileReader = new FileReader(inputFile);
                List<string> lines = fileReader.ReadLinesFromFile();

                double average = CalculateAverage(lines);

                Console.WriteLine("Average: " + average);

                FileWriter writer = new FileWriter(outputfile);
                writer.WriteAverageToFile(average);

                Console.WriteLine("Results written to output.txt");
            }
            catch (FileNotFoundException ex)
            {
                HandleException(ex, "input.txt not found.");
            }
            catch (FormatException ex)
            {
                HandleException(ex, "input.txt contains non-numeric data.");
            }
            catch (IOException ex)
            {
                HandleException(ex, "An I/O exception occurred during file operations.");
            }
            catch (Exception ex)
            {
                HandleException(ex, "An unexpected error occurred.");
            }
        }

        private void HandleException(Exception ex, string userFriendlyMessage)
        {
            _logger.LogException(ex);
            Console.WriteLine("Error: " + userFriendlyMessage);
        }
    }
}
