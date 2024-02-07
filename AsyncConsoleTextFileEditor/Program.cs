using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string fileName = "example.txt";

        var textFileEditor = new TextFileEditor(fileName);

        // Simulate multiple tasks performing operations on the same file concurrently
        var tasks = new Task[]
        {
            Task.Run(async () =>
            {
                await textFileEditor.UpdateTextFileAsync("Task 1: Updated content", Task.CurrentId ?? -1);
            }),
            Task.Run(async () =>
            {
                await textFileEditor.UpdateTextFileAsync("Task 2: Updated content", Task.CurrentId ?? -1);
            }),
            Task.Run(async () =>
            {
                await textFileEditor.UpdateTextFileAsync("Task 3: Updated content", Task.CurrentId ?? -1);
            })
        };

        await Task.WhenAll(tasks);
        
        string content = await textFileEditor.ReadTextFileAsync();
        Console.WriteLine(content);
        Console.WriteLine("All tasks completed.");

        #region Allow users to interactively edit the content within the console.

        //TextFileEditor textFileEditor = new TextFileEditor("file.txt");


        //while (true)
        //{
        //    Console.WriteLine("\nMenu:");
        //    Console.WriteLine("1. Update a Text File");
        //    Console.WriteLine("2. Read a Text File");
        //    Console.WriteLine("3. Write a Text File");

        //    Console.WriteLine("4. Exit");

        //    Console.Write("Choose an option: ");

        //    string choice = Console.ReadLine();

        //    switch (choice)
        //    {
        //        case "1":
        //            await textFileEditor.UpdateTextFileAsync();
        //           break;
        //        case "2":
        //            string readContent = await textFileEditor.ReadTextFileAsync();
        //            Console.WriteLine(readContent);
        //            break;
        //        case "3":
        //            Console.Write("enter the content: ");
        //            string content = Console.ReadLine();
        //            await textFileEditor.WriteTextFileAsync(content);
        //            break;
        //        case "4":
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.WriteLine("Invalid option. Please try again.");
        //            break;
        //    }
        //}

        #endregion


    }
}
 









