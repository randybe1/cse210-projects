using System;

namespace Develop04
{
  public class ReflectingActivity : Activity
  {
     protected List<string> _RandomPrompts = new List<string>
    {
     "Think of a time when you stood up for someone else.",
     "Think of a time when you did something really difficult.",
     "Think of a time when you helped someone in need.",
     "Think of a time when you did something truly selfless."
    };
      protected List<string> _RandomQuestions = new List<string>
    {
     "How did it feel when it was complete.?",
     "What is you favourite thing about this experience?",
     "What is something you does not like about this experience?",
     "How could you face something similar now?"
    };
    
    public ReflectingActivity(string activity, string description) : base (activity, description)
    {
        

    }

    public string Prompt()
    {
        Random Prompt = new Random();
        int x = Prompt.Next(_RandomPrompts.Count);
        string y = _RandomPrompts[x];
        Console.WriteLine($"{y}");
        return y;
    }
    public string Question()
    {
         Random Prompt = new Random();
        int x = Prompt.Next(_RandomQuestions.Count);
        string y = _RandomQuestions[x];
        Console.WriteLine($"{y}");
        return y;
    }

    public void ReflectionComplete()
    {
        Console.WriteLine("Consider the following prompt:");
        Prompt();
        Console.WriteLine("When you have gathered your thoughts, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they realated to this experience.");
        Console.WriteLine("You may begin in:"); PausingShowingCountdownTime(10);
        while(DateTime.Now < _endTime)
        {
            Question();
            if (DateTime.Now <_endTime)
            {
                PausingShowingSpinner(5);
                Question();
                PausingShowingSpinner(5);
                Question();
            }
        }
        LastMessage();
       

    }
}
}