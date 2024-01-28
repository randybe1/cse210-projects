using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        string book = "Proverbs";
        string chapter = "3";
        string verse = "5-6";
        string verse2 = ""; //if needed

        string userInput = "";

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine();

        Scripture scripture = new Scripture();

        Reference reference = new Reference(book, chapter, verse, verse2);
    
        scripture._reference = reference.GetReference();

        while(scripture.FullyHidden() && userInput != "quit")
        {
            scripture.GetScriptureText();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            Console.Clear(); // Clear Console 
            scripture.HideRandomWords(3); 
            
        }
   
    }
}