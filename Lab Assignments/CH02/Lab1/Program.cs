// See https://aka.ms/new-console-template for more information
const double KM_PER_MILE = 1.6;
Console.WriteLine("Please enter miles traveled.");
string userInput = Console.ReadLine();
double miles = Convert.ToDouble(userInput);
double kilometers = miles * KM_PER_MILE;
Console.WriteLine("There is {0} miles in {1} kilometers.", miles, kilometers);
