using System;

namespace Develop05
{
    public class SimpleGoal : Goal
{
    public override void GetInfo()
        {
            Console.Write("What is the name of your simple goal? ");
            _goalName = Console.ReadLine();

            Console.Write("What is a short description of your simple goal? ");
            _goalDescription = Console.ReadLine();

            Console.Write("How many points do you want associated with this goal? "); 
            _pointsPerTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
    public override string GetStringRepresentation()
    {
        return ($"{_goalType}: {_goalName}, {_goalDescription}, {_pointsPerTime}, {_isCompleted}");

    }
}
}