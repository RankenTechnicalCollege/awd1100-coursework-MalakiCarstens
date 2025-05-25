// See https://aka.ms/new-console-template for more information
const decimal shirtPrice = 14.99m;
const decimal tax = 0.08m;
Console.WriteLine("Please enter your name.");
string nameInput = Console.ReadLine();
Console.WriteLine("Please enter your street address.");
string addressInput = Console.ReadLine();
Console.WriteLine("Please enter the city you live in.");
string cityInput = Console.ReadLine();
Console.WriteLine("Please enter the state you live in.");
string stateInput = Console.ReadLine();
Console.WriteLine("Please enter your zip code.");
double zipInput = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter the quantity of shirts you ordered.");
int shirtInput = Convert.ToInt32(Console.ReadLine());

decimal totalPrice = shirtInput * shirtPrice;
decimal salesTax = totalPrice * tax;
decimal amountDue = totalPrice + salesTax;

Console.WriteLine("Name:    {0}", nameInput);
Console.WriteLine("Street Address:  {0}", addressInput);
Console.WriteLine("City:    {0}",cityInput);
Console.WriteLine("State:   {0}", stateInput);
Console.WriteLine("Zip Code:    {0}", zipInput);
Console.WriteLine("Total Price: {0:C}", totalPrice);
Console.WriteLine("Sales Tax:   {0:C}", salesTax);
Console.WriteLine("Amount Due:  {0:C}", amountDue);