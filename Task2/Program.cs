// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Сколько строк в матрице");

        int lines = int.Parse(Console.ReadLine());

        Console.WriteLine("Сколько столбцом в матрице");

        int columns = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[lines, columns];
        int[,] matrix2 = new int[lines, columns];
        int[,] resMatrix = new int[lines, columns];

        Random random = new Random();

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i, j] = random.Next(100);
            }
        }

        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix2[i, j] = random.Next(100);
            }
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                int var1 = matrix1[i, j];
                int var2 = matrix2[i, j];
                resMatrix[i,j] = var1 + var2;
            }
        }

        for (int i = 0; i < resMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resMatrix.GetLength(1); j++)
            {
                Console.Write($"{resMatrix[i, j], 4}");
            }
            Console.WriteLine();
        }
    }
}
