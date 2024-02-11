using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    public class GoalManager
{

    public List<Goal> _goalsObjects = new List<Goal>();

    public int _totalPoints;

    public void GetTotalPoints()
    {

        if (_goalsObjects.Count == 0)
        {
            _totalPoints = 0;
        }
        else
        {
            foreach (Goal goal in _goalsObjects)
            {

                _totalPoints = +goal._accumulatedPoints;
            }
        }
    }

    public void ShowListOfGoals()
    {

        if (_goalsObjects.Count != 0)
        {

            int counter = 1;
            foreach (Goal goal in _goalsObjects)
            {
                if (goal._goalType == "Simple Goal") 
                {
                    if (goal._isCompleted == "false")
                    {
                        Console.WriteLine($"{counter}. [ ] {goal._goalName} ({goal._goalDescription})");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"{counter}. [X] {goal._goalName} ({goal._goalDescription})");
                        counter++;
                    }

                }
                else if (goal._goalType == "Eternal Goal")
                {
                    Console.WriteLine($"{counter}. [ ] {goal._goalName} ({goal._goalDescription})");
                        counter++;
                }
                else if (goal._goalType == "Checklist Goal")
                {
                    if (goal._isCompleted == "false")
                    {
                        Console.WriteLine($"{counter}. [ ] {goal._goalName} ({goal._goalDescription}) --- Currently Completed {goal._timesCompleted}/{goal._numTimesToComplete}");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"{counter}. [x] {goal._goalName} ({goal._goalDescription}) --- Currently Completed {goal._timesCompleted}/{goal._numTimesToComplete}");
                        counter++;
                    }
                }
            }

        }
        else
        {
            Console.WriteLine("You haven't recorded any goal yet!...");
            Thread.Sleep(5000);
        }

        Console.WriteLine("Wait...");
        Thread.Sleep(5000);
    }
    public void ShowMainMenu()
    {

            Console.WriteLine($"You have {_totalPoints} points");
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

 public int SelectTypeOfGoal()
{
    Console.Clear();
    Console.WriteLine("The Types of goals are:");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");

    int userChoice;
    while (true)
    {
        Console.Write("Which type of goal would you like to create? ");
        if (int.TryParse(Console.ReadLine(), out userChoice))
        {
            if (userChoice >= 1 && userChoice <= 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    return userChoice;
}


    public void AddGoalObject(Goal goal)
    {
        _goalsObjects.Add(goal);

    }

    public void SaveGoals()
    {

        Console.WriteLine("What would you like to name the file? ");
        string filename = Console.ReadLine();
        using (StreamWriter textfile = new StreamWriter(filename, true))
        {
            foreach (Goal goal in _goalsObjects)
            {
                string stringRepresentation = goal.GetStringRepresentation();
                textfile.WriteLine(stringRepresentation);

            }
            textfile.Flush();
        }
    }

    public void LoadGoals()
    {

        _goalsObjects.Clear();

        GetTotalPoints();

        Console.WriteLine("What is the name of the file?: ");
        string filename = Console.ReadLine();


        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            string[] lineParts = line.Split(":");
            string[] goalParts = lineParts[1].Split(",");

            if (Convert.ToString(lineParts[0]) == "Simple Goal")
            {
                SimpleGoal simpleGoal = new SimpleGoal();

                simpleGoal.SetGoalType(Convert.ToString(lineParts[0].TrimStart()));
                simpleGoal.SetGoalName(Convert.ToString(goalParts[0].TrimStart()));
                simpleGoal.SetGoalDescription(Convert.ToString(goalParts[1].TrimStart()));
                simpleGoal.SetGoalPoints(Convert.ToInt32(goalParts[2]));
                simpleGoal.SetisCompleted(Convert.ToString(goalParts[3].TrimStart()));

                _goalsObjects.Add(simpleGoal);
            }

            else if (Convert.ToString(lineParts[0]) == "Eternal Goal")
            {
                EternalGoal eternalGoal = new EternalGoal();

                eternalGoal.SetGoalType(Convert.ToString(lineParts[0].TrimStart()));
                eternalGoal.SetGoalName(Convert.ToString(goalParts[0].TrimStart()));
                eternalGoal.SetGoalDescription(Convert.ToString(goalParts[1].TrimStart()));
                eternalGoal.SetPointsPerTime(Convert.ToInt32(goalParts[2]));

                _goalsObjects.Add(eternalGoal);

            }

            else if (Convert.ToString(lineParts[0]) == "Checklist Goal")
            {

                ChecklistGoal checklistGoal = new ChecklistGoal();

                checklistGoal.SetGoalType(Convert.ToString(lineParts[0].TrimStart()));
                checklistGoal.SetGoalName(Convert.ToString(goalParts[0].TrimStart()));
                checklistGoal.SetGoalDescription(Convert.ToString(goalParts[1].TrimStart()));
                checklistGoal.SetPointsPerTime(Convert.ToInt32(goalParts[2]));
                checklistGoal.SetTimesToComplete(Convert.ToInt32(goalParts[3]));
                checklistGoal.SetGoalPoints(Convert.ToInt32(goalParts[4]));
                checklistGoal.SetTimesCompleted(Convert.ToInt32((goalParts[5])));
                checklistGoal.SetisCompleted(Convert.ToString(goalParts[6].TrimStart()));

                _goalsObjects.Add(checklistGoal);
            }
            else
            {
                Console.WriteLine("Processing complete.");
            }
        }
    }
}
}