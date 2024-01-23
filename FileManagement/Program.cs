using FileProcessing;
using Microsoft.Extensions.Logging;



string inputFile = "input.txt";
string outputFile = "output.txt";

try
{
   
    DataProcessor dataProcessor = new DataProcessor(new FileLogger());
    string fileIn = dataProcessor.CreateFile(inputFile);
    FileWriter writer = new FileWriter(fileIn);
    writer.WriteToFile("jaflfdbg5fhgjslfsalaag;;h");
    writer.WriteToFile("affn5vnj");
    writer.WriteToFile("afh-2gj");
    string fileOut = dataProcessor.CreateFile(outputFile);
    dataProcessor.ProcessData(fileIn, fileOut);
 
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}

