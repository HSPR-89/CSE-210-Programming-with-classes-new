using System;
using System.Runtime.Serialization.Formatters;

class Program
{
    class Job
    {
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;
        public Job()
        {
        }
        public void display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}.");
        }
    }

    class Resume
    {
        public string _name = "";
        public List<Job> _jobs = new List<Job>();
        public Resume()
        {

        }
        public void display()
        {
            Console.WriteLine($"Name:{_name} \nJobs: ");
            foreach (Job line in _jobs)
            {
                line.display();
            }
        }
    }
    static void Main(string[] args)
{
    Job Howard = new Job();
    Howard._company = "Boston Scientific";
    Howard._jobTitle = "Equipment Engineer";
    Howard._startYear = 2014;
    Howard._endYear = 2019;

    Job Howard1 = new Job();
    Howard1._company = "Edwards Lifesciences";
    Howard1._jobTitle = "Equipment Transfer Engineer";
    Howard1._startYear = 2020;
    Howard1._endYear = 2022;

    Resume CV= new Resume();
    CV._name= "Howard Pereira";
    CV._jobs.Add(Howard);
    CV._jobs.Add(Howard1);
    CV.display();
}
}

