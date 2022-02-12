using Fiorella.DataAccessLayer;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace Fiorella.Controllers
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
            var sliderImages = _dbContext.SliderImages.ToList();
            var slider = _dbContext.Sliders.SingleOrDefault();
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.Include(x => x.Category).ToList();
            var about = _dbContext.Abouts.SingleOrDefault();
            var aboutServices = _dbContext.AboutServices.ToList();
            var expertSection = _dbContext.ExpertsSections.SingleOrDefault();
            var experts = _dbContext.Experts.ToList();
            var subscribe = _dbContext.Subscribes.SingleOrDefault();
            var blogSection = _dbContext.BlogSections.SingleOrDefault();
            var blogs = _dbContext.Blogs.ToList();
            var says = _dbContext.Says.ToList();
            var instagrams = _dbContext.Instagrams.ToList();
            return View(new HomeViewModel
            {
                SliderImages = sliderImages,
                Slider = slider,
                Products = products,
                Categories = categories,
                About = about,
                AboutServices = aboutServices,
                ExpertsSection = expertSection,
                Experts = experts,
                Subscribe = subscribe,
                Blogs = blogs,
                BlogSection = blogSection,
                Says = says,
                Instagrams = instagrams
            });
        }
    }
}
