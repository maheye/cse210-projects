using System;

class Program
{
    static void Main(string[] args)
    {   
        Random RandomGenerator = new Random();
        int number = RandomGenerator.Next(1, 101);
        Console.WriteLine($"What is the magic number? {number}");
        int guess = -1;
        int count = 0;
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess= int.Parse(Console.ReadLine());
            count += 1;

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {count} time to guess!");
            }
        
        }
    }
}