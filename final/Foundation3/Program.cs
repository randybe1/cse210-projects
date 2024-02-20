using System;
namespace Foundation3
{
class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
               
        Lectures lecture = new Lectures("Lecture", "Eternal Marriage", "Come and hear a leading expert in Marrige Counseling: Includes proper communication, quality time and Love languages.", "February 27th, 2023", "3:00 PM", "912 N 8th St Cheney, WA 99004", "Mark Mahbear, Home and Family Professor", 150);
        events.Add(lecture);
        
        Console.WriteLine(lecture.GetShortDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetLectureFullDetails());
        Console.WriteLine();
        
        OutdoorGatherings outdoorGathering = new OutdoorGatherings("OutdoorGathering", "Valentines day", "Bring  Roses and chocolate", "February 14th, 2024", "7:30 PM", "19 6th st Cheney , WA 99004");
        events.Add(outdoorGathering);

        Console.WriteLine(outdoorGathering.GetShortDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetOutdoorFullDetails());
        Console.WriteLine();

        Receptions reception = new Receptions("Reception", "Wedding Reception", "Come join us to celebrate David & Sarah on their marriage", "February 26th, 2024", "6:00 PM", "42516 N. Melville Rd Cheney, WA 99004");
        events.Add(reception);

        Console.WriteLine(reception.GetShortDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetReceptionFullDetails());
        Console.WriteLine();
        
    }
}
}
