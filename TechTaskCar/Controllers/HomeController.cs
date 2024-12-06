using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechTaskCar.Models;

namespace TechTaskCar.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    //creating context of my submission model 
    private readonly TechTaskDbContext _context;

    public HomeController(ILogger<HomeController> logger, TechTaskDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Submission user)
    {

        //checks if the forms fields validation has passed  
        if (ModelState.IsValid)
        {

            // Add the user to the database
            _context.Submission.Add(user);
            _context.SaveChanges();

            // Redirect to another page or show success message
            return RedirectToAction("Index");
        }

        // Return the form with validation errors
        return View(user);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
