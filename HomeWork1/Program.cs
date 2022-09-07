internal class Program
{
    private static void Main(string[] args)
    {
        string fullName = "Grigorii Riabov";
        int age = 30;
        string email = "some@mail.com";
        double programmingScore = 3.5;
        double mathScore = 4.0;
        double physicsScore = 1.1;

        Console.WriteLine($"Полное имя: {fullName}  Возраст: {age}  Емейл: {email} Баллы по программированию: {programmingScore} Баллы по математике: {mathScore} Баллы по физике: {physicsScore} ");

        Console.ReadLine();

        double scoreSumm = programmingScore + mathScore + physicsScore;

        double scoreAverage = scoreSumm / 3;

        Console.WriteLine($"Сумма баллов: {scoreSumm:#.##}  Среднее арифметическое баллов: {scoreAverage:#.##}");
    }
}