using System;
namespace Develop05
{
class Program
{
     static void Main(string[] args)
    {

        GoalManager goalmanager = new GoalManager();


        bool runProgram = true;
        while (runProgram)
        {
            goalmanager.ShowMainMenu();
            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
            {

                int goalType = goalmanager.SelectTypeOfGoal();

                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.SetGoalType("Simple Goal");
                    simpleGoal.GetInfo();
                    goalmanager.AddGoalObject(simpleGoal);
                }

                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetGoalType("Eternal Goal");
                    eternalGoal.GetInfo();
                    goalmanager.AddGoalObject(eternalGoal);
                }

                else if (goalType == 3)
                {
                    ChecklistGoal checkListGoal = new ChecklistGoal();
                    checkListGoal.SetGoalType("Checklist Goal");
                    checkListGoal.GetInfo();
                    goalmanager.AddGoalObject(checkListGoal);
                }

            }

            else if (userChoice == 2)
            {
                goalmanager.ShowListOfGoals();
            }


            else if (userChoice == 3)
            {
                goalmanager.SaveGoals();
            }


            else if (userChoice == 4)
            {
                goalmanager.LoadGoals();
            }


            else if (userChoice == 5)
            {
                Console.Clear();
                int counter = 1;
                foreach (Goal goal in goalmanager._goalsObjects)
                {

                    Console.WriteLine($"{counter}- {goal._goalName}");
                    counter++;
                }

                Console.WriteLine();
                Console.WriteLine("Which goal did you accomplish?: ");
                int goalToRecord = Convert.ToInt32(Console.ReadLine()) - 1;


                if (goalmanager._goalsObjects[goalToRecord]._goalType == "Simple Goal")
                {
                    goalmanager._goalsObjects[goalToRecord]._accumulatedPoints = 0;
                    goalmanager._goalsObjects[goalToRecord]._isCompleted = "True";
                    goalmanager._goalsObjects[goalToRecord]._accumulatedPoints += goalmanager._goalsObjects[goalToRecord]._goalPoints;
                    
                    goalmanager._totalPoints += goalmanager._goalsObjects[goalToRecord]._accumulatedPoints;
                                        
                    Console.WriteLine($"Congratulations!  You have earned {goalmanager._goalsObjects[goalToRecord]._goalPoints} points!");
                    Console.WriteLine($"You now have {goalmanager._totalPoints} points.\n");
                }

                else if (goalmanager._goalsObjects[goalToRecord]._goalType == "Eternal Goal")
                {
                    goalmanager._goalsObjects[goalToRecord]._accumulatedPoints = 0;
                    goalmanager._goalsObjects[goalToRecord]._accumulatedPoints += goalmanager._goalsObjects[goalToRecord]._pointsPerTime;
                    
                    goalmanager._totalPoints += goalmanager._goalsObjects[goalToRecord]._accumulatedPoints;

                    Console.WriteLine($"Congratulations!  You have earned {goalmanager._goalsObjects[goalToRecord]._pointsPerTime} points!");
                    Console.WriteLine($"You now have {goalmanager._totalPoints} points.\n");
                }

                else if (goalmanager._goalsObjects[goalToRecord]._goalType == "Checklist Goal")
                {
                    goalmanager._goalsObjects[goalToRecord]._accumulatedPoints = 0;
                    if (goalmanager._goalsObjects[goalToRecord]._timesCompleted < goalmanager._goalsObjects[goalToRecord]._numTimesToComplete -1)
                    {
                        goalmanager._goalsObjects[goalToRecord]._timesCompleted += 1;
                        
                        goalmanager._goalsObjects[goalToRecord]._accumulatedPoints += goalmanager._goalsObjects[goalToRecord]._pointsPerTime;
                        
                        goalmanager._totalPoints += goalmanager._goalsObjects[goalToRecord]._accumulatedPoints;

                        Console.WriteLine($"Congratulations!  You have earned {goalmanager._goalsObjects[goalToRecord]._pointsPerTime} points!");
                        Console.WriteLine($"You now have {goalmanager._totalPoints} points.\n");
                    }
                    
                    else if (goalmanager._goalsObjects[goalToRecord]._timesCompleted < goalmanager._goalsObjects[goalToRecord]._numTimesToComplete)
                    {
                        goalmanager._goalsObjects[goalToRecord]._timesCompleted += 1;
                        goalmanager._goalsObjects[goalToRecord]._isCompleted = "True";
                        goalmanager._goalsObjects[goalToRecord]._accumulatedPoints += (goalmanager._goalsObjects[goalToRecord]._goalPoints + goalmanager._goalsObjects[goalToRecord]._pointsPerTime);
                        goalmanager._totalPoints += goalmanager._goalsObjects[goalToRecord]._accumulatedPoints;

                        Console.WriteLine($"Congratulations!  You have earned {goalmanager._goalsObjects[goalToRecord]._accumulatedPoints} points!");
                        Console.WriteLine($"You now have {goalmanager._totalPoints} points.\n");
                        Console.WriteLine("You have completed this goal!\n");
                    }
                    else 
                    {
                        Console.WriteLine("This goal has already been completed!");
                    }

                }
            }
            else if (userChoice == 6)
            {
                break;
            }
        }
    }
}
}