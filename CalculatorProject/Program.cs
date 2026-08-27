namespace CalculatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Num: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second Num: ");
            var num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter operation (+, -, *, /): ");
            var operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "/":
                   Console.WriteLine($"Result: {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;

            }




        }
    }
}
