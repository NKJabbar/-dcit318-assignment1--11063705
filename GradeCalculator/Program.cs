using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter numerical grade (0-100): ");
        string input = Console.ReadLine();

        if (!double.TryParse(input, out double grade) || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            return;
        }

        string letter;
        if (grade >= 90) letter = "A";
        else if (grade >= 80) letter = "B";
        else if (grade >= 70) letter = "C";
        else if (grade >= 60) letter = "D";
        else letter = "F";

        Console.WriteLine($"Numerical grade: {grade}. Letter grade: {letter}");
    }
}
