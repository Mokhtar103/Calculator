namespace CalculatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Num: ");

            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Invalid first number.");
                return;
            }

            Console.Write("Enter second Num: ");

            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Invalid second number.");
                return;
            }

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
