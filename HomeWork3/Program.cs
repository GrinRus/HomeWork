// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Сколько строк в матрице");

        int lines = int.Parse(Console.ReadLine());

        Console.WriteLine("Сколько столбцом в матрице");

        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[lines, columns];

        Random random = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = random.Next(100);
            }
        }

        long sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int var = matrix[i, j];
                sum += var;
                Console.Write($"{var, 3}");
            }
            Console.WriteLine();
        }

        Console.Write($"Сумма матрицы {sum}");
    }
}
