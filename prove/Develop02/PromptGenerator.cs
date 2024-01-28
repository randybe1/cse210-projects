using System;
using System.IO;
public class PromptGenerator
{
    public List<String> _prompts = new List<String>();

    Random randomGenerator = new Random();
public void CreatePrompts()
   {
      string prompt1 = "How was your day?";
      _prompts.Add(prompt1);
      string prompt2 = "What was the highlight of your day?";
      _prompts.Add(prompt2);
      string prompt3 = "What was the strongest emotion you have felt today and why?";
      _prompts.Add(prompt3);
      string prompt4 = "If you could change anything about today what would that be?";
      _prompts.Add(prompt4);
      string prompt5 = "What was your goals for today?";
      _prompts.Add(prompt5);
      string prompt6 = "Were you able to acheive your set goals for today?";
      _prompts.Add(prompt6);
   } 
    public string ChooseRandomPrompt()
    {
        int randomNumber = randomGenerator.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];
        return prompt;
    }

}