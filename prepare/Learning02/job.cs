using System;

//Create the class job
public class Job 
{
    //add the variables with underscore and lowercase letter.
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayAllDetails()
   {
       Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
   }

}

