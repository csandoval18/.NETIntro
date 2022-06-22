using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
  public class HelloWordController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

  }
}