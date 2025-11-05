//                                                   1

using System;


Console.Write("Enter a number from 1 to 100: ");
int n = int.Parse(Console.ReadLine());

if (n < 1 || n > 100)
{
    Console.WriteLine("Error: number must be between 1 and 100");
}
else if (n % 3 == 0 && n % 5 == 0)
{
    Console.WriteLine("Fizz Buzz");
}
else if (n % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (n % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(n);
}

Console.WriteLine();



Console.Write("Enter a value: ");
double value = double.Parse(Console.ReadLine());

Console.Write("Enter a percent to calculate: ");
double percent = double.Parse(Console.ReadLine());

double result = value * percent / 100;
Console.WriteLine($"{percent}% of {value} = {result}");

Console.WriteLine();


//                                                3 

Console.WriteLine("Enter 4 digits one by one:");
string d1 = Console.ReadLine();
string d2 = Console.ReadLine();
string d3 = Console.ReadLine();
string d4 = Console.ReadLine();

string number4 = d1 + d2 + d3 + d4;
Console.WriteLine("Result: " + number4);

Console.WriteLine();


//                                            4

Console.Write("Enter a 6-digit number: ");
string six = Console.ReadLine();

if (six.Length != 6)
{
    Console.WriteLine("Error: number must contain exactly 6 digits");
}
else
{
    Console.Write("Enter the first position to swap (1-6): ");
    int p1 = int.Parse(Console.ReadLine()) - 1;

    Console.Write("Enter the second position to swap (1-6): ");
    int p2 = int.Parse(Console.ReadLine()) - 1;

    char[] arr = six.ToCharArray();
    (arr[p1], arr[p2]) = (arr[p2], arr[p1]);

    Console.WriteLine("Result: " + new string(arr));
}

Console.WriteLine();


//                                                 5 

Console.Write("Enter a date (dd.mm.yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());

string season;

if (date.Month == 12 || date.Month == 1 || date.Month == 2)
    season = "Winter";
else if (date.Month >= 3 && date.Month <= 5)
    season = "Spring";
else if (date.Month >= 6 && date.Month <= 8)
    season = "Summer";
else
    season = "Autumn";

Console.WriteLine($"{season} {date.DayOfWeek}");

Console.WriteLine();


//                             6 

Console.Write("Enter temperature value: ");
double temp = double.Parse(Console.ReadLine());

Console.Write("Choose conversion (1 - Fahrenheit to Celsius, 2 - Celsius to Fahrenheit): ");
int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    double c = (temp - 32) * 5 / 9;
    Console.WriteLine($"Result: {c:F2} °C");
}
else if (choice == 2)
{
    double f = temp * 9 / 5 + 32;
    Console.WriteLine($"Result: {f:F2} °F");
}
else
{
    Console.WriteLine("Error: invalid option");
}

Console.WriteLine();


//                                                     7
Console.Write("Enter the start of the range: "); 
int a = int.Parse(Console.ReadLine());

Console.Write("Enter the end of the range: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    int tmp = a;
    a = b;
    b = tmp;
}

Console.WriteLine($"Even numbers from {a} to {b}:");

for (int i = a; i <= b; i++)
{
    if (i % 2 == 0)
       Console.Write(i + " ");
}

Console.WriteLine();
