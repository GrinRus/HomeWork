// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
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
}
