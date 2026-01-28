// Exercise 1: Ask age -> calculate birth year

const int CURRENT_YEAR = 2026;

Console.Write("Please enter your age: ");
int age = int.Parse(Console.ReadLine());

int yearOfBirth = CURRENT_YEAR - age;

Console.WriteLine($"You were born in {yearOfBirth}");

// ====================================================================

// Exercise 2: Temparature converter (C <-> F)

Console.Write("Please enter degree: ");
double degree = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your unit you want convert to: (C/F): ");
string unit = Console.ReadLine();

if (unit != "C" && unit != "F")
{
    Console.WriteLine("Please enter target unit you want convert. (Capitalize it)");
}

if (unit == "C")
{
    // TODO: convert F -> C
    double convertFToC = (degree - 32) * 5 / 9;
    Console.WriteLine($"{degree}°F -> {Math.Round(convertFToC, 2)}°C");
}

if (unit == "F")
{
    // TODO: convert C -> F
    double convertCToF = degree * 9 / 5 + 32;
    Console.WriteLine($"{degree}°C -> {Math.Round(convertCToF, 2)}°F");
}

// ====================================================================

// Exercise 3: Simple interest calculator (principal, rate, time).
/*
    Provide several options for time period:
    - 3 months => rate = 3%
    - 6 months => rate = 5%
    - 9 months => rate = 7%
    - 1 year => rate = 10%
*/

decimal rate = 0m;

Console.WriteLine("Recommendation rates for different time periods:");
Console.WriteLine("<3 months => rate = 3%");
Console.WriteLine("<6 months => rate = 5%");
Console.WriteLine("<9 months => rate = 7%");
Console.WriteLine("12+ months => rate = 10%\n");

Console.Write("Enter your principal amount: ");
decimal principalAmount = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter your time period (as month): ");
int timePeriod = Convert.ToInt32(Console.ReadLine());

if (timePeriod <= 3)
    rate = 3;
else if (timePeriod <= 6)
    rate = 5;
else if (timePeriod <= 9)
    rate = 7;
else
    rate = 10;


decimal interestPerMonth = Math.Ceiling(principalAmount * rate / 100);

decimal totalInterest = interestPerMonth * timePeriod;

decimal totalPayment = principalAmount + totalInterest;

Console.WriteLine($"Your interest per month: ${interestPerMonth}");
Console.WriteLine($"Your total interest: ${totalInterest}");
Console.WriteLine($"Your total payment: ${totalPayment}");
