using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleTask.DAL.Context;
using PurpleTask.Models;
using System.Diagnostics;

namespace PurpleTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly PurpleDbContext _dbContext;
        public HomeController(PurpleDbContext dbContext )
        {
            _dbContext= dbContext;
        }
        public async Task< IActionResult> Index()
        {
            List<Slider> sliders = await _dbContext.Sliders.ToListAsync();
            return View(sliders);
        }

       
    }
}