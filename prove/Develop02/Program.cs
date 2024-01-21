using System;
class Program
{
  static void Main(string[] args)
  { 
    Journal journal = new Journal();

    PromptGenerator promptGenerator = new PromptGenerator();

    do 
    {
      Console.WriteLine(" Welcome to the Journal Program");


      string inputU = Console.ReadLine();

      if (inputU == "1")
      {
        string pop = promptGenerator.GetRandomPrompt();
        Console.WriteLine(pop);

        string pop2 = Console.ReadLine();
      
        Entry entry = new Entry();
        entry._promptText = pop;
        entry._entryText = pop2;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        entry._date = dateText;

        journal.AddEntry(entry);
      }
       if (inputU == "2")
       {
         journal.DisplayAll();
       }
    }
    while (true);
 
  }
}