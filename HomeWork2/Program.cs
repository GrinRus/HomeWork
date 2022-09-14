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
                case 4: minNumber(); break;
                case 5: guessTheNumber(); break;
            }
        }
    }

    private static void printMenu()
    {
        Console.WriteLine("0. Exit 1. Odd or even 2. 21 game 3. prime number 4. min number 5. Guess the number");
    }
    private static void evenOrOdd()
    {

    }

    private static void game21()
    {

    }

    private static void primeNumber()
    {

    }

    private static void minNumber()
    {

    }

    private static void guessTheNumber()
    {

    }
}