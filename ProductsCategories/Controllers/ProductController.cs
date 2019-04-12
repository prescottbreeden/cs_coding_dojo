using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsCategories.Models;

namespace ProductsCategories.Controllers
{
    public class ProductController : Controller
    {
        ProductsContext dbContext;

        public ProductController(ProductsContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToAction("Products");
        }

        [HttpGet("products")]
        public IActionResult Products()
        {
            List<Product> allProducts = dbContext.Products.ToList();

            ProductsPage model = new ProductsPage();
            model.ExistingProducts = allProducts;
            ViewBag.Title = "Products";

            return View(model);
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            List<Category> allCategories = dbContext.Categories.ToList();

            CategoriesPage model = new CategoriesPage();
            model.ExistingCategories = allCategories;
            ViewBag.Title = "Categories";

            return View(model);
        }

        [HttpGet("categories/{categoryId}")]
        public IActionResult Category(int categoryId)
        {
            Category category = dbContext.Categories
                .FirstOrDefault(c => c.CategoryId == categoryId);

            List<Product> availableProducts = dbContext.Products.ToList();

            List<Product> currentProducts = dbContext.Products
                .Include(p => p.Associations)
                .ToList();

            CategoryPage model = new CategoryPage();
            model.Category = category;
            model.CurrentProducts = currentProducts;
            model.AvailableProducts = availableProducts;
            model.Title = "Categories";

            return View(model);
        }

        [HttpPost("newProduct")]
        public IActionResult NewProduct(NewProduct form)
        {
            Product newProduct = new Product()
            {
                Name = form.Name,
                Description = form.Description,
                Price = form.Price
            };
            dbContext.Products.Add(newProduct);
            dbContext.SaveChanges();
            return RedirectToAction("Products");
        }

        [HttpPost("newCategory")]
        public IActionResult NewCategory(NewCategory form)
        {
            Category newCategory = new Category()
            {
                Name = form.Name
            };
            dbContext.Categories.Add(newCategory);
            dbContext.SaveChanges();
            return RedirectToAction("Categories");
        }

    }
}
