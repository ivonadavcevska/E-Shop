using E_Shop.Data;
using E_Shop.Models;
using E_Shop.Services;
using E_Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Shop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsServiceInterface productsService;

        

        public ProductsController(ProductsServiceInterface service)
        {
            
            productsService = service;
            
        }

        
        public IActionResult Index(string searchString = null, int page=1)
        {

            var products = productsService.getProductsBySearch(searchString,page);


            return View(products);

        }


        
        public IActionResult FilteredProducts(List<string> colors, int page=1)
        {
            
            var products = productsService.getProductsByFilter(colors, page);

            return View("Index", products);

        }

        
        public IActionResult Details(int id) 
        {
            var product = productsService.getProductById(id);
            return View(product);
        }

        
        public IActionResult Create() 
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Product product)
        {
            productsService.addNewProduct(product);

            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int id)
        {
            productsService.deleteProduct(id);

            return RedirectToAction("Index");
        }



    }
}
