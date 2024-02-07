using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class TextFileEditor
{
    private SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);
    private string _filePath;

    public TextFileEditor(string fileName)
    {
        _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        if (!File.Exists(_filePath))
        {
            // Create the file if it doesn't exist
            using (FileStream fs = File.Create(_filePath))
            {
                Console.WriteLine($"File '{fileName}' created in the bin directory.");
            }
        }
    }

    public async Task UpdateTextFileAsync(string newContent, int taskId)
    {
        try
        {
            await semaphore.WaitAsync();
            string content = await ReadTextFileAsync();
            Console.WriteLine($"\nCurrent content of {Path.GetFileName(_filePath)}:\n{content}");
            await WriteTextFileAsync(newContent);
            Console.WriteLine($"Content updated by Task {taskId}");
            Console.WriteLine($"New content of {Path.GetFileName(_filePath)}:\n{newContent}");
        }
        finally
        {
            semaphore.Release();
        }
    }

    public async Task<string> ReadTextFileAsync()
    {
        using (StreamReader reader = new StreamReader(_filePath))
        {
            return await reader.ReadToEndAsync();
        }
    }

    public async Task WriteTextFileAsync(string content)
    {
        using (StreamWriter writer = new StreamWriter(_filePath, true, Encoding.UTF8))
        {
            await writer.WriteLineAsync(content);
        }
    }
}