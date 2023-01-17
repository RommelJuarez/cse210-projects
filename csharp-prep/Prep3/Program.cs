using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magic_number= randomGenerator.Next(1,11);

        int guess=-1; 
        while (magic_number!=guess)
        {
            Console.WriteLine($"Magic number: {magic_number}");
            Console.Write("What is your guess?: ");
            guess=int.Parse(Console.ReadLine());

            if(guess<magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess>magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it! :D");
            }
        }
        
    }
}