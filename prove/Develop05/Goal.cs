using System;


namespace Develop05
{
public class Goal
{

    public string _goalName;
    public string _goalDescription;
    public int _goalPoints;

    public int _accumulatedPoints = 0;
    public string _goalType;

    public int _numTimesToComplete;
    public int _pointsPerTime;

    public int _timesCompleted = 0;

    public string _isCompleted = "false";
public void CompleteTask()
    {
        // Check if the goal is already completed
        if (_isCompleted == "True")
        {
            Console.WriteLine("This goal has already been completed!");
            return;
        }

        // Update accumulated points based on the goal type
        if (_goalType == "Simple Goal")
        {
            // For simple goals, accumulate points based on the goal points
            _accumulatedPoints += _goalPoints;
        }
        else if (_goalType == "Eternal Goal")
        {
            // For eternal goals, accumulate points based on points per time
            _accumulatedPoints += _pointsPerTime;
        }
        else if (_goalType == "Checklist Goal")
        {
            // For checklist goals, accumulate points based on points per time and completion status
            if (_timesCompleted < _numTimesToComplete - 1)
            {
                _accumulatedPoints += _pointsPerTime;
            }
            else if (_timesCompleted < _numTimesToComplete)
            {
                // If the goal is completed after this task, add the remaining points
                _accumulatedPoints += (_goalPoints + _pointsPerTime);
                _isCompleted = "True";
                Console.WriteLine("Congratulations! You have completed this goal!");
            }
            else
            {
                Console.WriteLine("This goal has already been completed!");
            }
        }

        // Increment times completed for checklist goals
        if (_goalType == "Checklist Goal" && _timesCompleted < _numTimesToComplete)
        {
            _timesCompleted++;
        }

        Console.WriteLine($"Congratulations! You have earned {_accumulatedPoints} points!");
    }
    public virtual void GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        _goalDescription = Console.ReadLine();

        Console.Write("How many points do you want associated with this goal: ");
        _goalPoints = Convert.ToInt32(Console.ReadLine());
    }

    public virtual string GetStringRepresentation()
    {
        return ($"{_goalType}: {_goalName}, {_goalDescription}, {_goalPoints}");
    }

    public void SetGoalDescription(string description)
    {
        _goalDescription = description;
    }
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public void SetisCompleted(string isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public void SetPointsPerTime(int pointsPerTime)
    {
        _pointsPerTime = pointsPerTime;
    }

    public void SetTimesToComplete(int SetTimesToComplete)
    {
        _numTimesToComplete = SetTimesToComplete;
    }

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }

}
}