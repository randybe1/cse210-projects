using System;

namespace Develop05
{
   public class ChecklistGoal : Goal
{

    public override void GetInfo()
    {
        Console.Write("What is the name of your checklist goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of your checklist goal? ");
        _goalDescription = Console.ReadLine();

        Console.Write("How many points do you want associated with this goal? "); 
        _pointsPerTime = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many times does this goal needs to be accomplished for a bonus? ");
        _numTimesToComplete = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many bonus points for accomplishing it that many times? ");
        _goalPoints = Convert.ToInt32(Console.ReadLine());
    }

    public override string GetStringRepresentation()
    {
        return ($"{_goalType}: {_goalName}, {_goalDescription}, {_pointsPerTime}, {_numTimesToComplete}, {_goalPoints}, {_timesCompleted}, {_isCompleted}");

    }

    public int getNumTimesCompleted()
    {
        return _timesCompleted;
    }
}
}