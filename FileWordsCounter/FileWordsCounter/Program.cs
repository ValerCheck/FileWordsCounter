using System;

namespace FileWordsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("This is FileWordsCounter application.");
                Console.WriteLine("Provide path to your text file, and I will count all unique words in your text.");
                return;
            }
            var fileName = args[0];
            string content = null;
            if (FileProcessor.TryGetFileContent(fileName, out content))
            {
                var output = TextProcessor.CountWordsFromTextAndGenerateOutputMessage(content);
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Something went wrong :(");
                Console.WriteLine("Please, check path to your file or provide another path and try again.");
            }
            Console.ReadLine();
        }
    }
}
