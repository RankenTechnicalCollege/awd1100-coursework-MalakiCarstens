// See https://aka.ms/new-console-template for more information
const double TAX_RATE = 0.08;
int entryNum = 0;
double total = 0;
double price;

do
{
    Console.WriteLine("Enter item price or enter '0' to finish.");
    string input = Console.ReadLine();

    if (!double.TryParse(input, out price))
    {
        Console.WriteLine("Invalid Entry");
        continue;
    }
    if (price == 0)
    {
        break;
    }
    if (price < 0)
    {
        Console.WriteLine("Please enter positive numbers.");
        continue;
    }
    total += price;
    entryNum++;
}
while (true);

double priceAverage = total / entryNum;
double totalTax = total * TAX_RATE;
double finalTotal = total + totalTax;

Console.WriteLine($"Items Purchased: {entryNum}");
Console.WriteLine($"Average Item Price: {priceAverage:F2}");
Console.WriteLine($"Pre Tax total: {total:F2}");
Console.WriteLine($"Tax: {totalTax:F2}");
Console.WriteLine($"Post Tax Total: {finalTotal:F2}");


