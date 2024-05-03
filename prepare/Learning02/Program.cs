using System;

class Program
{
    static void Main(string[] args)
    {
        //Add the job1 instance
        Job job1 = new Job();
        //add the variables with dot notation
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2011;
        job1._endYear = 2017;

        Job job2 = new Job();

        job2._jobTitle = "Web Designer";
        job2._company = "Instagram";
        job2._startYear = 2017;
        job2._endYear = 2024;

        //display the company of the job.
        
        //Console.WriteLine (job1._company) ;
        
        //call the new method
        //job1.DisplayAllDetails();
        //job2.DisplayAllDetails();

        //Add a new Instance Resume class
        Resume myResume = new Resume();

        //Add the names
        myResume._name = "Leslie Resio";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume.DisplayAllDetails();

    }


}