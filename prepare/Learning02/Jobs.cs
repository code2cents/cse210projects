using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    
    // tried to do something here but it didnt work
    //public Job(string argJobTitle, string Argcompany, int argStartYear, int argEndYear)
   // {
   //     _jobTitle = argJobTitle;
   //     _company = Argcompany;
   //     _startYear = argStartYear;
   //     _endYear = argEndYear;

   //     Console.WriteLine($"{argJobTitle} ({Argcompany}) {argStartYear}-{argEndYear}");
   // }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}