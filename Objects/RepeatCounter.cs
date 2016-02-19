using System.Collections.Generic;
using System;
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
      string[] words = sentence.Split(' ');
      foreach(string word in words)
      {
        if(word.ToLower() == testWord.ToLower())
        {
            count++;
        }
      }
      return count;
    }
  } // end class
} // end namespace
