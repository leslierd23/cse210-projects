using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? " );
        string gradeUser = Console.ReadLine();
        int gradePercent = int.Parse(gradeUser);

        string letterGrade = "";

        if (gradePercent >= 90 )
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent > 70)
        {
            letterGrade = "C";
        }
        else if (gradePercent > 60)
        {
            letterGrade ="D";
        }
        else if (gradePercent < 60){
            letterGrade ="F";
        }
    
        
        Console.WriteLine($"Your Grade percentage is {letterGrade}.");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else{
            Console.WriteLine("I'm sorry, bette luck next time!");
        }

        
      }  }