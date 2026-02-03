// * Operators and Control flow

// Exercise 1: Even/odd checker
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 != 0)
{
    Console.WriteLine("Odd number");
}
else
{
    Console.WriteLine("Even number");
}

// Exercise 2: Sum of first N natural numbers (user inputs)
int sum = 0;

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    sum += i;
}

Console.WriteLine($"Sum of 1 to {number} = {sum}");

// Exercise 3: Print mutilplication table (1 - 12).
for (int i = 1; i <= 12; i++)
{
    for (int j = 1; j <= 12; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine("============");
}

// Exercise 4: Guess random number in range 1 - 100, give hints higher/lower.
int random = new Random().Next(1, 101);

Console.WriteLine(random);

int maxAttempts = 10;
int time = 0;
while (time <= maxAttempts)
{
    Console.Write("Enter a number: ");
    int userInput = int.Parse(Console.ReadLine());

    if (userInput > 100 || userInput < 0)
    {
        Console.WriteLine("Please enter number in range 1 - 100!!!");
    }

    if (userInput > random)
    {
        Console.WriteLine("Lower!");
    }
    else if (userInput < random)
    {
        Console.WriteLine("Higher!");
    }
    else if (userInput == random)
    {
        Console.WriteLine("You're win! Congratulation 🎉");
        break;
    }
    else
    {
        Console.WriteLine("Try again 😢");
    }
    time++;
}