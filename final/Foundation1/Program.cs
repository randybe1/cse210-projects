using System;
namespace Foundation1
{
class Program
{
static void Main(string[] args)
{
    Console.Clear();

    Video video = new Video("How to remote start your 2018-2022 Honda CR-V", "Randy the Jamaican Beckford", "1332 seconds");
    video.DisplayVideoInfo();
    video.AddComment("Mark", "Love the video!");
    video.AddComment("Angie", "Thank you this helped so much!");
    video.AddComment("David", "You forgot to mention that the car must be running.");
    video.DisplayComments();

    Video video2 = new Video("How to program your memory seat on Honda Pilots 2016-2022", "Mike_Shaw Cars", "2093 seconds");
    video2.DisplayVideoInfo();
    video2.AddComment("Karen", "where have you been all my life, I've been struggling with this for so long, thank you.");
    video2.AddComment("Gabril", "I think you need to work on your camera angles.");
    video2.AddComment("Jennifer", "Could you please do a Video about the tailgate setup?");
    video2.DisplayComments();

    Video video3 = new Video("2023 - 2024 Honda Pilot EX-L Vehicle Settings", "Crazy Honda Chris", "1016 seconds");
    video3.DisplayVideoInfo();
    video3.AddComment("Mike", "Never noticed how nice the new pilots look!");
    video3.AddComment("Joe", "I like the older body style pilots but this one is not bad.");
    video3.AddComment("Jessica", "OMG! I love the color.");
    video3.AddComment("Ron Stopable", "Is that original stitching on the seat?");
    video3.DisplayComments();
}
}
}