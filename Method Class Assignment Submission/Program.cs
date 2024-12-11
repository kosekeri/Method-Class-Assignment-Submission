
namespace ConsoleAppExample
{
    // This is the class where the void method is defined
    class MathOperations
    {
        // This method takes two integers as parameters
        // Performs a math operation on the first integer (e.g., multiply by 2)
        // Displays the second integer
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on num1 and display the result
            int result = num1 * 2; // Multiply num1 by 2
            Console.WriteLine($"Result of operation on first number: {result}");

            // Display the second integer
            Console.WriteLine($"Second number provided: {num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method, passing in two numbers
            mathOps.PerformOperation(5, 10);

            // Call the PerformOperation method again, specifying the parameters by name
            mathOps.PerformOperation(num1: 8, num2: 20);

            // Pause the console to allow the user to see the output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

