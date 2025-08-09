using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string? input = Console.ReadLine();

        if (input == null || !int.TryParse(input, out int age) || age < 0)
        {
            Console.WriteLine("Invalid age. Please enter a non-negative integer.");
            return;
        }

        const decimal fullPrice = 10m;
        const decimal discountPrice = 7m;

        decimal ticketPrice = (age >= 65 || age <= 12) ? discountPrice : fullPrice;

        Console.WriteLine($"Age: {age}. Ticket price: GHC{ticketPrice}");
    }
}