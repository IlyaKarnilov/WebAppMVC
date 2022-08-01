using Microsoft.AspNetCore.Mvc;
using WebAppMVCTest.Models;

namespace WebAppMVCTest.Controllers;

public class WorldController : Controller
{
    
    public IActionResult Index()
    {
        DogViewModel doggi = new DogViewModel() {Name = "Jefri", Age = 5};    
        return View(doggi);
    }
}