namespace DataTypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Data types!");

            // integer - taisarv
            int bigNumber = int.MaxValue;
            Console.WriteLine($"max int: {bigNumber}");

            long longNumber = long.MaxValue;
            Console.WriteLine($"max long: {longNumber}");

            //12.5
            float floatMax = float.MaxValue;
            Console.WriteLine($"max float: {floatMax}");

            float floatVariable = 12.5f;
            Console.WriteLine($"float: {floatVariable}");

            // veel komaga arv
            double doubleMax = double.MaxValue;
            Console.WriteLine($"max double: {doubleMax}");

            //tahemark
            string stringVariable = "asd24235234525634 !@#$%^&*()_+[],.";
            Console.WriteLine($"string: {stringVariable}");

            //true and false
            bool boolVariable = false;
            Console.WriteLine($"bool: {boolVariable}");
        }
    }
}