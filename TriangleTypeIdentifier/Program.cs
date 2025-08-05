using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Enter the three sides of the triangle (one at a time):");
        double a = ReadPositiveDouble("Side a: ");
        double b = ReadPositiveDouble("Side b: ");
        double c = ReadPositiveDouble("Side c: ");

        if (!IsTriangle(a, b, c))
        {
            Console.WriteLine("The given sides do not form a valid triangle.");
            return;
        }

        if (AreEqual(a, b) && AreEqual(b, c))
            Console.WriteLine("Triangle type: Equilateral");
        else if (AreEqual(a, b) || AreEqual(b, c) || AreEqual(a, c))
            Console.WriteLine("Triangle type: Isosceles");
        else
            Console.WriteLine("Triangle type: Scalene");
    }

    static double ReadPositiveDouble(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        if (!double.TryParse(input, out double val) || val <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            Environment.Exit(0);
        }
        return val;
    }

    static bool IsTriangle(double x, double y, double z)
    {
        // triangle inequality
        return x + y > z && x + z > y && y + z > x;
    }

    static bool AreEqual(double x, double y, double eps = 1e-9)
    {
        return Math.Abs(x - y) <= eps;
    }
}
