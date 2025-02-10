namespace IfElseCalculator
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

            if (calculationType == 1)
            {
                result = number + number2;
                Console.WriteLine("Answer: ");
                Console.WriteLine($"{number} + {number2} = {result}");
            }
            else if (calculationType == 2)
            {
                result = number - number2;
                Console.WriteLine("Answer: ");
                Console.WriteLine($"{number} - {number2} = {result}");
            }
            else if (calculationType == 3)
            {
                result = number * number2;
                Console.WriteLine("Answer: ");
                Console.WriteLine($"{number} * {number2} = {result}");
            }
            else if (calculationType == 4)
            {
                if(number2 == 0)
                {
                    Console.WriteLine("ERROR: Cannot divide by 0");
                }
                else
                {
                    result = number / number2;
                    Console.WriteLine("Answer: ");
                    Console.WriteLine($"{number} / {number2} = {result}");
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
