public class Journal
{
	 public List<String> _entries = new List<String>();
	string _filename;
	DateTime theCurrentTime = DateTime.Now;
	public void AddEntry(string prompt, string entry)
	{
		string date = theCurrentTime.ToShortDateString();
        string formattedEntry = ($"Date: {date} - Prompt: {prompt}: \n{entry}");
        _entries.Add(formattedEntry);
	}

	public void DisplayEntry()
	{
		foreach(string line in _entries)
		{
			Console.WriteLine(line);
            Console.WriteLine();
		}
		WaitForKey();	
	}
	 public void SaveJournalFile()
	{
		Console.WriteLine("What would you like to name the file? ");
		string _filename = Console.ReadLine();
        if (!File.Exists(_filename))
		{
			using (StreamWriter textfile = new StreamWriter( _filename))
            {
                foreach (string line in _entries)
                {
                    textfile.WriteLine(line);
                }

		}
	}
	WaitForKey();  

	}	
	public void LoadJournalFile()
	{
		 Console.WriteLine("What is the filename? ");
        _filename = Console.ReadLine();
        
        if (!File.Exists(_filename))
        {
            Console.WriteLine("Sorry, that filename does not exist.");
        }
        else
        {
            _entries.Clear();

            string[] loadedEntries = File.ReadAllLines(_filename); 
            foreach (string loadEntry in loadedEntries)
            {
                _entries.Add(loadEntry);
            }
        }
        WaitForKey();
	}
	 public void WaitForKey()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\nPress any key...");
        Console.ReadKey(true);
    }
	
}