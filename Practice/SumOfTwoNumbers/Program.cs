namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = a + b;
            
            Console.WriteLine("Sum = " + Math.Round(sum, 2));
        }
    }
}