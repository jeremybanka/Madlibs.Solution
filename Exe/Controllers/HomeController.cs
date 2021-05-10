using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("")]
    public ActionResult Index()
    {
      return View();
    }

    [Route("result")]
    public ActionResult Result(string noun)
    {
      MadlibsVariables userMadlibsVariables = new();
      userMadlibsVariables.Noun = noun;
      return View();
    }
  }
}