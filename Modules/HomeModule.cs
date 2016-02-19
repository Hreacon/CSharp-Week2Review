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
        return View["header.cshtml"];
      };
    }
  }
}
