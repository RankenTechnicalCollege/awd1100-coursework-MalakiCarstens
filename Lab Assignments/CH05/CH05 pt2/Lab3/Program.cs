// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

double danielleSales = 0;
double edwardSales = 0;
double francisSales = 0;

while (true)
{
    Console.WriteLine("Enter salesperson initial (d, e, f) or 'z' to quit:    ");
    string input = Console.ReadLine().ToLower();
    if (input == "z")
    {
        break;
    }
    else if (input == "d" || input == "e" || input == "f")
    {
        Console.WriteLine("Enter sales amount:  ");
        string amountInput = Console.ReadLine();
        double amount;

        if (double.TryParse(amountInput, out amount) && amount >= 0)
        {
            switch (input)
            {
                case "d":
                    danielleSales += amount;
                    break;

                case "e":
                    edwardSales += amount;
                    break;

                case "f":
                    francisSales += amount;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invaild sales amount. Please enter a positive number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid intial. Please enter 'd', 'e', 'f', or 'z'.");
    }

   }
        double grandTotal = danielleSales + edwardSales + francisSales;

        Console.WriteLine("\nSales Summary:");
        Console.WriteLine($"Danielle: ${danielleSales:F2}");
        Console.WriteLine($"Edward:   ${edwardSales:F2}");
        Console.WriteLine($"Francis:  ${francisSales:F2}");
        Console.WriteLine($"Grand Total: ${grandTotal:F2}");

        string topSalesperson;
        double topSales = Math.Max(danielleSales, Math.Max(edwardSales, francisSales));

            if (topSales == danielleSales)
                topSalesperson = "Danielle";
            else if (topSales == edwardSales)
                topSalesperson = "Edward";
            else
                topSalesperson = "Francis";

            Console.WriteLine($"Top Salesperson: {topSalesperson} with ${topSales:F2}");