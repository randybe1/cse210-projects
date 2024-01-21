using System;
using System.Collections;
using System.Text;
using JournalApp;
using static System.Console;

namespace JournalApp
{
class Program
{
    static void Main(string[] args)
    {
     Journal myJournal = new Journal();
	    
          bool isChoiceValid = false;
            string choice = "";
              do		
            {
              
              ForegroundColor = ConsoleColor.DarkGray;

                WriteLine(" \nPlease select one of the following choices");
                WriteLine("1. Write");
                WriteLine("2. Display");
                WriteLine("3. Load");
                WriteLine("4. Save");
                WriteLine("5. Qiuit");
          
              ForegroundColor = ConsoleColor.DarkGreen;
                choice = ReadLine().Trim();
          
              if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                  isChoiceValid = true;
                }
              else
              {
            ForegroundColor = ConsoleColor.Red;
              WriteLine($"\"{choice}\" is not a valid option. Please select between choices 1 - 5.");
                WaitForKey();
              }

		}
		  while (!isChoiceValid);
		    return "choice";


        private void RunMenu()
	{
		        string choice;
              do
              {
                choice = GetChoice();
                  switch(choice)
                {
                  case"1":
                    AddEntry();
                    break;
                  case "2":
                    DisplayJournalContent();
                    break;
                  case"3":
                    Load();
                    break;
                  case"4":
                    Save();
                    break;
                  case"5":
                    Clear();
                    break;	
                  default:
                    break;
                }
              } while(choice != "5");
              }
    }  
  }
}