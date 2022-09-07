    internal class Task1

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
        }
    }