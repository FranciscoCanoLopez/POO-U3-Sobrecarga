using POO_U3_Sobrecarga;

class Program
{
    static void Main(string[] args)
    {
        Operation operation = new Operation();

        // Adding two numbers
        Console.WriteLine("Sum of 5 and 3: " + operation.Sum(5, 3));

        // Subtracting two numbers
        Console.WriteLine("Difference of 5 and 3: " + operation.Subtract(5, 3));

        // Adding three numbers
        Console.WriteLine("Sum of 5, 3, and 2: " + operation.Sum(5, 3, 2));

        // Subtracting three numbers
        Console.WriteLine("Difference of 5, 3, and 2: " + operation.Subtract(5, 3, 2));
    }
}