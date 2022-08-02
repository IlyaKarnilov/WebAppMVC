using Microsoft.AspNetCore.Mvc;
using WebAppMVCTest.Models;

namespace WebAppMVCTest.Controllers;

public class WorldController : Controller
{
    private static List<DogViewModel> _dogs = new List<DogViewModel>(); 
    public IActionResult Index()
    {
        return View(_dogs);
    }

    public IActionResult Create()
    {
        var dogVM = new DogViewModel();
        return View(dogVM);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        _dogs.Add(dogViewModel);
        return RedirectToAction(nameof(Index));
    }
}