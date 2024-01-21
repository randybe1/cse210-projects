using System;
using System.Collections;
using System.Text;
using static System.Console;
using System.IO;

namespace JournalApp
{
class Journal
{
	public string JournalFile = "MyJournal.txt";

    	
	public void CreateJournalFile() 
	{
		//WriteLine($"Does file exist? {File.Exists("MyJournal.txt")}");
		if(!File.Exists(JournalFile))
		{
			File.CreateText(JournalFile);
		}
	}
	private void DisplayIntro() 
	{
		ForegroundColor = ConsoleColor.Blue;
		BackgroundColor = ConsoleColor.White;
		Clear();
		Console.WriteLine("Welcome the Journal Program");
		Console.WriteLine("Please select one of the following choices:");
		WaitForKey();
	}
	private void DisplayOutro()
	{
		Console.WriteLine("Thank you for using the Journal Program");
		WaitForKey();
	}
	private void WaitForKey()
	{
			ForegroundColor = ConsoleColor.DarkGray;
			WriteLine("\nPress any Key...");
			ReadKey(true);
	}
	private void DisplayJournalContent()
	{
		string journalText = File.ReadAllText(JournalFile);
		WriteLine("\n === Journal ===:");
		WriteLine(journalText);
		WriteLine("===============================");
		WaitForKey();
	}
	private void ClearFile ()
	{
		ForegroundColor = ConsoleColor.Black;
		File.WriteAllText(JournalFile, "");
		WriteLine("\nJournal cleared");
		WaitForKey();
	}
	private void AddEntry () 
	{
		ForegroundColor = ConsoleColor.Black;
		WriteLine("\nType EXIT and press enter to stop");
		ForegroundColor = ConsoleColor.DarkMagenta;
		string newEntry = "";
		bool shouldContinue = true;
		while(shouldContinue)
		{
			string line = ReadLine();
                if (line.ToLower().Trim() != "exit")
                {
                    newEntry += line + "\n";
                }
                else
                {
                    shouldContinue = false;
                }
            }
		File.AppendAllText(JournalFile, $"\nEntry:\n>{newEntry}\n");
		ForegroundColor = ConsoleColor.Black;
		WriteLine("The Journal has been modified!");
		WaitForKey();
	}
	
}
}
