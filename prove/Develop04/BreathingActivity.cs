using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class  BreathingActivity : Activity
   {
    public BreathingActivity(string activity, string description) : base (activity, description)
    {
        

    }

    public void BreathIn()
    {
        Console.WriteLine("Breath in...");PausingShowingCountdownTime(3);
    }

    public void BreathOut()
    {
        Console.WriteLine("Breath out...");PausingShowingCountdownTime(6);
    }

    public void BreathComplete()
    {
         while(DateTime.Now < _endTime)
        {
            BreathIn();
            if (DateTime.Now <_endTime)
            {
                BreathOut();
            }
        }

    }

   
}
}
