using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleTask.DAL.Context;
using PurpleTask.ViewModels;

namespace PurpleTask.Controllers
{
    public class WorkController : Controller
    {
        private readonly PurpleDbContext _dbContext;
        public WorkController(PurpleDbContext dbContext)
        {
                _dbContext=dbContext;
        }
        public async Task< IActionResult> Index()
        {
            CardCategoryViewModel model = new CardCategoryViewModel()
            {
                Categories = await _dbContext.Categories.ToListAsync(),
                Cards = await _dbContext.Card
                .Include(c => c.Category).
                ToListAsync(),

            };
            return View(model);
        }
    }
}
