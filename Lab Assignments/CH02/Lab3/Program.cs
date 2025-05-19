// See https://aka.ms/new-console-template for more information
const double PERCENT_RAISE = 0.04;
Console.WriteLine("Enter name of employee 1.");
    string employee1 = Console.ReadLine();
Console.WriteLine("Enter {0} current salary.", employee1);
    double salary1_2025 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter name of employee 2.");
    string employee2 = Console.ReadLine();
Console.WriteLine("Enter {0} current salary.", employee2);
    double salary2_2025 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter name of employee 3.");
    string employee3 = Console.ReadLine();
Console.WriteLine("Enter {0} current salary.", employee3);
    double salary3_2025 = Convert.ToDouble(Console.ReadLine());
double salary1_2026 = salary1_2025 * (1 + PERCENT_RAISE);
double salary2_2026 = salary2_2025 * (1 + PERCENT_RAISE);
double salary3_2026 = salary3_2025 * (1 + PERCENT_RAISE);

double salary1_2027 = salary1_2026 * (1 + PERCENT_RAISE);
double salary2_2027 = salary2_2026 * (1 + PERCENT_RAISE);
double salary3_2027 = salary3_2026 * (1 + PERCENT_RAISE);
Console.WriteLine("Year        {0}            {1}           {2}", employee1, employee2, employee3);
Console.WriteLine("2025        {0}            {1}           {2}", salary1_2025, salary2_2025, salary3_2025);
Console.WriteLine("2026        {0}            {1}           {2}", salary1_2026, salary2_2026, salary3_2026);
Console.WriteLine("2027        {0}            {1}           {2}", salary1_2027, salary2_2027, salary3_2027);