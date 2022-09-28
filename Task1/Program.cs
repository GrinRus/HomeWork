// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите текст");

        string input = Console.ReadLine();

        string[] words = GetWordsFromInput(input);

        PrintWords(words);
    }

    private static void PrintWords(string[] words)
    {
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    private static string[] GetWordsFromInput(string lines)
    {
        return lines.Split(' ');
    }
}
