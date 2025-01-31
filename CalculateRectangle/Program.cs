namespace CalculateRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculte rectangle");

            Console.Write("Enter first value: ");
            string firstNumber = Console.ReadLine();
            float floatFirst = float.Parse(firstNumber);

            Console.Write("Enter second value: ");
            string secondNumber = Console.ReadLine();
            float floatSecond = float.Parse(secondNumber);

            //teha pindala ja umbermoodu kalkulatsioon
            float P = 2 * (floatFirst + floatSecond);
            float S = floatFirst * floatSecond;
            Console.WriteLine($"P: {P}");
            Console.WriteLine($"S: {S}");

            for (int i = 0; i < floatSecond; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(i);
            }
        }
    }
}
