// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a number.");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter another number.");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter one final number.");
double num3 = Convert.ToDouble(Console.ReadLine());

double average = (num1 + num2 + num3) / 3;
Console.WriteLine("Your average is {0:F}", average);