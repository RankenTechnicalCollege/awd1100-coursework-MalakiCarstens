// See https://aka.ms/new-console-template for more information
const double MILES_RATE = 0.50;
const double DAILY_RATE = 100;
Console.WriteLine("How many days did you drive the car?");
    double days = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("How many miles did you drive in the car?");
    double miles = Convert.ToDouble(Console.ReadLine());
double total = (days * DAILY_RATE) + (miles * MILES_RATE);
Console.WriteLine("Your total cost is {0}.", total);
