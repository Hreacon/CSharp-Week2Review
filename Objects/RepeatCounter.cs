using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace RepeatCounterNS.Objects
{
  public class RepeatCounter
  {
    public RepeatCounter()
    {
    }
    
    public int CountRepeats(string sentence, string testWord)
    {
      int count = 0;
      // setup regex pattern
      string[] words = sentence.Split(' ');
      Regex rgx = new Regex("[\\p{P}-]+");
      foreach(string word in words)
      {
        if(rgx.Replace(word.ToLower(), "") == testWord.ToLower())
        {
            count++;
        }
      }
      return count;
    }
  } // end class
} // end namespace
