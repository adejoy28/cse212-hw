using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");

        var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        var myString = new List<string>() { "John", "david", "Mark", "Joe", "Jane", "Boys", "Mane" };


        Console.WriteLine(numbers[1]);
        Console.WriteLine(myString[2]);
        myString.Add("Tolu");
        // myString.Insert(1, "Bisola");
        Console.WriteLine(myString.Count == 0);

        Console.WriteLine("\n\n");

        for (var i = 0; i < myString.Count; ++i)
        {
            Console.WriteLine(myString[i]);
        }

        Console.WriteLine("\n\n");
        Console.WriteLine("Size: " + myString.Count);
        Console.WriteLine("Capacity: " + myString.Capacity);
    }
}