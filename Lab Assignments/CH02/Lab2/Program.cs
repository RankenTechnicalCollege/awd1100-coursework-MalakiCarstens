// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter 1st test score.");
    double test1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 2nd test score.");
    double test2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 3rd test score.");
    double test3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter 4th test score.");
    double test4 = Convert.ToDouble(Console.ReadLine());
double average = (test1 + test2 + test3 + test4) / 4;
Console.WriteLine("Your average test score is {0}.", average);