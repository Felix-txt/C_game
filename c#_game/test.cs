using System;
// för att skapa en ny skriv dotnet new console
// för att bygga och köra programmet skriv dotnet run
internal class NewBaseType
{
    static void Main(string[] args)
    {
        // Print "Hello, World!" to the console.
        Console.WriteLine("Hello, World!");
        Console.WriteLine("enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        // Wait for user input before closing the console window.
    }
}

