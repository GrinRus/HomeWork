internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Какое максимальное число будем угадывать");

        int maxNum = int.Parse(Console.ReadLine());

        Random random = new Random();

        int generatedNum = random.Next(maxNum + 1);

        while (true)
        {
            Console.WriteLine("Введите число");

            string readLine = Console.ReadLine();
            if (readLine.Equals(""))
            {
                Console.WriteLine($"Вы не угадали, число: {generatedNum}");
                break;
            }
            int insertedNum = int.Parse(readLine);

            if (insertedNum == generatedNum)
            {
                Console.WriteLine($"Вы угадали, число: {generatedNum}");
            }
            else if (insertedNum > generatedNum)
            {
                Console.WriteLine("Введеное число больше");
            }
            else if (insertedNum < generatedNum)
            {
                Console.WriteLine("Введеное число меньше");
            }
        }
    }
}