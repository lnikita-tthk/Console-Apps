namespace CalculatorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");

            Console.WriteLine("Insert calculation type by number: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int calculationType = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert first number and press enter");
            float number = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number and press enter");
            float number2 = float.Parse(Console.ReadLine());

            float result = 0;

            switch(calculationType)
            {
                case 1:
                    result = number + number2;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine($"{number} + {number2} = {result}");
                    break;
                case 2:
                    result = number - number2;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine($"{number} - {number2} = {result}");
                    break;       
                case 3:
                    result = number * number2;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine($"{number} * {number2} = {result}");
                    break;                
                case 4:
                    result = number / number2;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine($"{number} / {number2} = {result}");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
