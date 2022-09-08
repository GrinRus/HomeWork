internal class Task1

{
    private static void Main(string[] args)
    {
        while (true)
        {
            printMenu();
            int command = int.Parse(Console.ReadLine());
            switch (command)
            {
                case 0: return;
                case 1: evenOrOdd(); break;
                case 2: game21(); break;
                case 3: primeNumber(); break;
                case 4: return;
            }
        }
    }
    private static void printMenu()
    {
        Console.WriteLine("0. Exit 1. Odd or even 2. 21 game 3. prime number");
    }
    private static void evenOrOdd()
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

    private static void game21()
    {
        Console.WriteLine("Сколько карт на руках");

        int cardCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Какие карты");

        int cardSum = 0;

        for (int i = cardCount; i > 0; i--)
        {
            string card = Console.ReadLine();
            int result;
            bool isInt = int.TryParse(card, out result);
            switch (isInt)
            {
                case true: cardSum += result; break;
                case false: cardSum += 10; break;
                default: throw new Exception();
            }
        }

        Console.WriteLine($"Сумма карт: {cardSum}");
    }

    private static void primeNumber()
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
        } else
        {
            Console.WriteLine("Число НЕ является простым");
        }
    }
}