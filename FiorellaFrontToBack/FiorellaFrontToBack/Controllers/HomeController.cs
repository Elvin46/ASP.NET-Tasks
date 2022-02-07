using FiorellaFrontToBack.DataAccessLayer;
using FiorellaFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FiorellaFrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var aboutServices = _dbContext.Services.ToList();
            var aboutSection = _dbContext.Abouts.SingleOrDefault();
            var expertSection = _dbContext.ExpertSections.SingleOrDefault();
            var experts = _dbContext.Experts.ToList();
            var subscribe = _dbContext.Subscribes.SingleOrDefault();
            return View(new HomeViewModel
            {
                AboutServices = aboutServices,
                AboutSection = aboutSection,
                ExpertSection = expertSection,
                Experts = experts,
                Subscribes = subscribe,
            });
        }
    }
}
