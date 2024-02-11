using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
  public class EternalGoal : Goal
{
    public override void GetInfo()
    {
        Console.Write("What is the name of your eternal Goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of your eternal Goal? ");
        _goalDescription = Console.ReadLine();

        _pointsPerTime = GetValidatedPoints("How many points do you want associated with this goal? ");
        Console.WriteLine();
    }

    private int GetValidatedPoints(string message)
    {
        int points;
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out points) && points > 0)
            {
                return points;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}: {_goalName}, {_goalDescription}, {_pointsPerTime}";
    }
}

}
