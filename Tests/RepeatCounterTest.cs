using Xunit;
using RepeatCounterNS.Objects;
namespace RepeatCounterNS
{
  public class RepeatCounterTest
  {
      // Test a single word, input "word", "word". Output 1.
    // This is the simplest way to test this function because there is only one input word.
    [Fact]
    public void CountRepeats_CountsOneWord()
    {
        RepeatCounter count = new RepeatCounter();
        Assert.Equal(1, count.CountRepeats("word", "word"));
    }
    /* EXAMPLE
    // Have a queen object that knows what coordinants its at
    [Fact]
    public void QueenAttack_ForCoordinants_SeeCoordinants()
    // {
      QueenAttack queen = new QueenAttack(8, 2);
      Assert.Equal(8, queen.GetX());
      Assert.Equal(2, queen.GetY());
    }
    /**/
  }
}
