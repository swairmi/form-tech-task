using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechTaskCar.Models;

namespace TechTaskCar.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly TechTaskDbContext _context;

    public HomeController(ILogger<HomeController> logger, TechTaskDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var topics = new List<SelectListItem>
        {
            new SelectListItem { Value = "Topic1", Text = "Topic 1" },
            new SelectListItem { Value = "Topic2", Text = "Topic 2" },
            new SelectListItem { Value = "Topic3", Text = "Topic 3" },
            new SelectListItem { Value = "Topic4", Text = "Topic 4" }
        };

        ViewBag.Topics = topics;

        return View();
    }

    [HttpPost]
    public IActionResult Index(Submission user)
    {
        if (ModelState.IsValid)
        {
            //allows the non-required fields to be null in the database
            user.Company = string.IsNullOrWhiteSpace(user.Company) ? null : user.Company;
            user.Title = string.IsNullOrWhiteSpace(user.Title) ? null : user.Title;
            user.Questions = string.IsNullOrWhiteSpace(user.Questions) ? null : user.Questions;



            _context.Submission.Add(user);
            _context.SaveChanges();
            
            

            // Store a success message in TempData
            TempData["SuccessMessage"] = $"Thank you, {user.FirstName}, for submitting the form!";

            return RedirectToAction("Index");
        }

        //holds thge drops downs options 
        var topics = new List<SelectListItem>
        {
            new SelectListItem { Value = "Topic1", Text = "Topic 1" },
            new SelectListItem { Value = "Topic2", Text = "Topic 2" },
            new SelectListItem { Value = "Topic3", Text = "Topic 3" },
            new SelectListItem { Value = "Topic4", Text = "Topic 4" }
        };

        ViewBag.Topics = topics;

        return View(user);
    }
 

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() =>
        View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}

