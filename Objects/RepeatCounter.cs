using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace RepeatCounterNS.Objects
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _testWord;
    private int _count;
    public RepeatCounter()
    {
      _sentence = "";
      _testWord = "";
    }
    public string GetSentence() { return _sentence; }
    public string GetWord() {return _testWord; }
    public int GetCount() {return _count; }
    public void Save(string sentence, string testWord, int count)
    {
      _sentence = sentence;
      _testWord = testWord;
      _count = count;
    }
    public int CountRepeats(string sentence, string testWord)
    {
      int count = 0;
      foreach(string word in sentence.Split(' '))
      {
        if(Regex.Replace(word.ToLower(), "[\\p{P}-\\^]+", "") == Regex.Replace(testWord.ToLower(), "[\\p{P}-\\^]+", ""))
        {
            count++;
        }
      }
      return count;
    }
  } // end class
} // end namespace
