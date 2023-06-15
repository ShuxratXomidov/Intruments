using Microsoft.AspNetCore.Mvc;

namespace Instruments.Controllers;
public class InstrumentsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
};