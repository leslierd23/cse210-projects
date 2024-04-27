using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userN = -1;
        while(userN != 0)
        {
            Console.Write("Enter a number please (0 to quit): ");

            string userR = Console.ReadLine();
            userN=int.Parse(userR);


            if (userN !=0)
            {
                numbers.Add(userN);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max=number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}