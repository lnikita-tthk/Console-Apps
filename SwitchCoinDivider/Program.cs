namespace SwitchCoinDivider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount in cents: ");
            int amount = int.Parse(Console.ReadLine());

            if (amount >= 50)
            {
                Console.WriteLine(amount / 50 + " x 50 cent(s)");
                amount = amount - (amount / 50) * 50;
            }

            if (amount >= 20)
            {
                Console.WriteLine(amount / 20 + " x 20 cent(s)");
                amount = amount - (amount / 20) * 20;
            }

            if (amount >= 10)
            {
                Console.WriteLine(amount / 10 + " x 10 cent(s)");
                amount = amount - (amount / 10) * 10;
            }

            if (amount >= 5)
            {
                Console.WriteLine(amount / 5 + " x 5 cent(s)");
                amount = amount - (amount / 5) * 5;
            }

            if (amount >= 2)
            {
                Console.WriteLine(amount / 2 + " x 2 cent(s)");
                amount = amount - (amount / 2) * 2;
            }

            if (amount >= 1)
            {
                Console.WriteLine(amount / 1 + " x 1 cent(s)");
            }
        }
    }
}
