using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Develop03
{
    public class Scripture
    {
      public string _reference;
      private string _scripturesText = "Trust in the LORD with all thine; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

      private List<Word> _words = new List<Word>();
      private List<Word> _wordsRemaining = new List<Word>();

      public Scripture()
      {
         List<string> toList = _scripturesText.Split(' ').ToList();
        
        foreach (string eachWord in toList)
        {
             Word word = new Word(eachWord);
            _words.Add(word);
        }
      }

      public Scripture(string scripture)
      {
        List<string> scripturetoList = scripture.Split(' ').ToList();
        
        foreach (string currentWord in scripturetoList)
        {
            Word word= new Word(currentWord);
            _words.Add(word);
        }

      }
      public void GetScriptureText()
      {
        Console.Write(_reference);

        foreach (Word word in _words)
        {
            Console.Write(word._text);
            Console.Write(" ");
        }
      }

      public void SetScripture(string scripture)
      {
        _scripturesText = scripture;
      }

      public void HideRandomWords(int quantityOfWordsToHide)
      {
        Random randomGenerator = new Random();

        for (int i = 0;  i < quantityOfWordsToHide; i++ )
        {
            int randomIndex = randomGenerator.Next(0, _words.Count());

            _words[randomIndex].Hide();
        }
      }

      public bool FullyHidden()
    {
        foreach (Word wordObject in _words)
        {
            if (wordObject._show == false)
            {
                continue;
            }
            if (wordObject._show == true)
            {
                return true;
            }
        }
        return false;
    }
      
    }
}