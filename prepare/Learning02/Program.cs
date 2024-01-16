using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Techdata";
        job1._startYear = 2000;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._jobTitle = "Chief Technology Officer";
        job2._company = "Samsung";
        job2._startYear = 2005;
        job2._endYear = 2008;

        Resume myResume = new Resume();
        myResume._name = "Luis Arturo Zegarra Marcelo";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}