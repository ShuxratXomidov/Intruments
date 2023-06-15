using Microsoft.AspNetCore.Mvc;

namespace Instruments.Controllers;

public class AuthController : Controller
{
    private readonly AppContext dbContext;

    public AuthController(AppContext appContext)
    {
        this.dbContext=appContext;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

}