using System.Text;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to the C# programming world!");

/* 
    Console.ReadLine();
        Using for reading input from the user.
        Only take string input.
*/

// Exercise: Take user name as input and greet the user with his name.
Console.Write("Enter your name: ");
string? username = Console.ReadLine();

System.Console.WriteLine($"Hello, {username}. Welcome!");


// ==========================================================