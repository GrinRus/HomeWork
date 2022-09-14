// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число");

        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        int someInt = 2;

        while (someInt < number)
        {
            if (number % someInt == 0)
            {
                isPrime = false;
            }
            someInt++;
        }

        if (isPrime)
        {
            Console.WriteLine("Число является простым");
        }
        else
        {
            Console.WriteLine("Число НЕ является простым");
        }
    }
}
