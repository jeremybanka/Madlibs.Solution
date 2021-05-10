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
    public ActionResult Result(string noun1)
    {
      MadlibsVariables userMadlibsVariables = new();
      userMadlibsVariables.Noun1 = noun1;
      return View(userMadlibsVariables);
    }
  }
}