using Nancy;
using RepeatCounterNS.Objects;
using System.Collections.Generic;
namespace RepeatCounterNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["repeatCounter.cshtml", new RepeatCounter()];
      };
      Post["/"] = _ => {
        RepeatCounter count = new RepeatCounter();
        string sentence = Request.Form["sentence"];
        string word = Request.Form["testWord"];
        count.Save(sentence, word, count.CountRepeats(sentence, word) );
        return View["repeatCounter.cshtml", count];
      };
    }
  }
}
