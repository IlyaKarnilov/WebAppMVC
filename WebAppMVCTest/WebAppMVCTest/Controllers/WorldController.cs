using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCTest.Controllers;

public class WorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}