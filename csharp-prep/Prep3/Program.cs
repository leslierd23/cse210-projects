using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?" );
        
        //int numberM = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int numberM = randomGenerator.Next(1,20);

        int guessNumber= -1;

        while (guessNumber != numberM )
        {
            Console.Write ("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (numberM > guessNumber)
            {
                Console.Write("Try Higher");
            }
            else if (numberM < guessNumber)
            {
                Console.WriteLine("Try lower please");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }


    }
}