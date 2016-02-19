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
      foreach(string word in sentence.Split(' '))
      {
        if(Regex.Replace(word.ToLower(), "[\\p{P}-\\^]+", "") == testWord.ToLower())
        {
            count++;
        }
      }
      return count;
    }
  } // end class
} // end namespace
