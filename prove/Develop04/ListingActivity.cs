using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
   public class ListingActivity : Activity
{
     protected List<string> _promptList = new List<string>
    {
     "Who are people that you appreciate?",
     "What are personal strengths of yours?.",
     "Who are people that you have helped this week?",
     "When have you felt the Holy Ghost this month?",
     "Who are some of your personal heroes?"
    };

    protected int _answers = 0;
    public ListingActivity(string activity, string description) : base (activity, description)
    {
        

    }

     public string promptList()
    {
        Random Prompt = new Random();
        int x = Prompt.Next(_promptList.Count);
        string y = _promptList[x];
        Console.WriteLine($"{y}");
        return y;
    }
    public void ListingComplete()
    {
        Console.WriteLine("List as many responses you can to the following propmt");
       promptList();
        Console.WriteLine("You may begin in:");
        PausingShowingCountdownTime(5);
        while(DateTime.Now < _endTime)
        {
            Console.ReadLine();
            _answers ++;
         }
         Console.WriteLine($"You list {_answers} items.");
         LastMessage();
           

    }
}
}