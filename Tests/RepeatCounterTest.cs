using Xunit;
using RepeatCounterNS.Objects;
namespace RepeatCounterNS
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_CountsOneWord()
    {
      RepeatCounter count = new RepeatCounter();
      Assert.Equal(1, count.CountRepeats("word", "word"));
    }
    [Fact]
    public void CountRepeats_IgnoresOtherWords()
    {
      RepeatCounter count = new RepeatCounter();
      Assert.Equal(1, count.CountRepeats("This word", "word"));
    }
    [Fact]
    public void CountRepeats_CountsMoreThanOneWord()
    {
      RepeatCounter count = new RepeatCounter();
      Assert.Equal(2, count.CountRepeats("This word word", "word"));
    }
    [Fact]
    public void CountRepeats_DoesntCountPartialMatches()
    {
      RepeatCounter count = new RepeatCounter();
      Assert.Equal(1, count.CountRepeats("this wordy word", "word"));
    }
    [Fact]
    public void CountRepeats_IgnoreCase()
    {
      RepeatCounter count = new RepeatCounter();
      Assert.Equal(2, count.CountRepeats("Word wordy word", "word"));
    }
    [Fact]
    public void CountRepeats_IgnorePunctuation()
    {
      RepeatCounter count = new RepeatCounter();
      Assert.Equal(1, count.CountRepeats("this wordy word.", "word"));
    }
    [Fact]
    public void CountRepeats_BreakTest()
    {
      RepeatCounter count = new RepeatCounter();
      Assert.Equal(6, count.CountRepeats("'tEsT. sentence is tEsTing the ?tEsT' a bility of tEsTing the program that tEsTs for string [tEsT] occurances in tEsT; string tEsTy tEsT^ 'tEsT.", "test"));
    }
  }
}
