using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine();
        Console.Write("What is your firt name?: ");
        string fisrt_name= Console.ReadLine();

        Console.Write("What is your last name?: ");
        string last_name= Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {last_name}, {fisrt_name} {last_name}.");
        Console.WriteLine();
    }
}