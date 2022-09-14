internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Сколько чисел в последовательности");

        int numbersCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Какие числа");

        int minNumber = int.MaxValue;

        for (int i = numbersCount; i > 0; i--)
        {
            int tempVal = int.Parse(Console.ReadLine());
            if (tempVal < minNumber)
            {
                minNumber = tempVal;
            }
        }

        Console.WriteLine($"Минимальное число: {minNumber}");
    }
}