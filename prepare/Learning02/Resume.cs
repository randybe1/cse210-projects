using System;

//Behaviors: Displays the resume, which shows the name first, followed by displaying each one of the jobs.
public class Resume
{
public string _name;
public List<Job> _jobs = new List<Job>();

public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
           job.Display();
        }
    }
}


