namespace CalculatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first Num: ");

                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid first number.");
                    continue;
                }

                Console.Write("Enter second Num: ");

                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid second number.");
                    continue;
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
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            break;
                        }

                        Console.WriteLine($"Result: {num1 / num2}");
                        break;

                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }

                Console.Write("Do you want to perform another calculation? (y/n): ");
                var answer = Console.ReadLine()?.ToLower();

                if (answer != "y")
                {
                    break;
                }

                Console.WriteLine();
            }


        }
    }
}
