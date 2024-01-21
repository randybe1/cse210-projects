using System;
using System.Collections;
using System.Text;
using static System.Console;
using System.IO;
using JournalApp;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
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

    private void WaitForKey()
    {
        ForegroundColor = ConsoleColor.DarkGray;
			WriteLine("\nPress any Key...");
			ReadKey(true);
    }

    public void Dispaly()
    {
       
    }

}