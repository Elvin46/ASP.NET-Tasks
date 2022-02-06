using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TaskProducts.DataAccessLayer;
using TaskProducts.Models;

namespace TaskProducts.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            //var grocery = new Category { Id = 1,Name = "Grocery" };
            //var dairy = new Category { Id = 2, Name = "Dairy" };
            //var bakery = new Category { Id = 3, Name = "Bakery" };

            //var products = new List<Product>
            //{
            //    new Product { Id = 1, Name = "Bread" , Price = 0.7, Category = bakery},
            //    new Product { Id = 2, Name = "Milk" , Price = 1.5, Category = dairy},
            //    new Product { Id = 3, Name = "Tomato" , Price = 12, Category = grocery},
            //    new Product { Id = 4, Name = "Cheese" , Price = 2.5, Category = dairy }
            //};

            var products = _dbContext.Products.Include(x => x.Category).ToList();

            return View(products);
        }
    }
}
