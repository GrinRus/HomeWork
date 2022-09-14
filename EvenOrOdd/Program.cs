// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число");

        string input = Console.ReadLine();

        int parsedInput = int.Parse(input);

        if (parsedInput % 2 == 1)
        {
            Console.WriteLine("Нечетное число");
        }
        else
        {
            Console.WriteLine("Четно число");
        }
        return;
    }
}
