using System.Collections.Generic;
using System;
namespace RepeatCounterNS.Objects
{
  public class RepeatCounter
  {
    public RepeatCounter()
    {
    }
    
    public int CountRepeats(string sentence, string word)
    {
        int count = 0;
        if(sentence.Contains(word))
        {
            count++;
        }
        return count;
    }
  } // end class
} // end namespace
