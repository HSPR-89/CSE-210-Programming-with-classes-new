using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Equipment Engineer";
        job1._company = "Boston Scientific";
        job1._startYear = 2014;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Transfer Engineer";
        job2._company = "Edwards Lifesciences";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Howard Pereira";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}