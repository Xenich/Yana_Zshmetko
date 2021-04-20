using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProductsWebApp.DataLayer;
using ProductsWebApp.DB;
using ProductsWebApp.Models;

namespace ProductsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataLayerInterface dl;

        public HomeController(ProductsContext context)
        {
            this.dl = new DBHelper(context);
        }

        public IActionResult Index()
        {
            ProductsViewModel model = new ProductsViewModel();
            model.Filter = new SelectList(dl.GetCategories(), "Id", "Name", 0);
            model.ItemsCountOnPage = new SelectList(new int[] {3,5,10 , 50}, 50);
            model.ProductsTable = dl.GetProductsTable(0,1,50);
            return View(model);
        }

        [HttpPost]
        public IActionResult GetProductsTable(int index, int currentPage, int itemsCount=5)
        {
            ProductsViewModel model = new ProductsViewModel();           
            model.ProductsTable = dl.GetProductsTable(index, currentPage, itemsCount);
            return PartialView("ProductsTableView", model.ProductsTable);
        }

        public IActionResult DeleteProduct(int id)
        {
            dl.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public string  AddProduct(int categoryIndex, string name)
        {
            try
            {
                dl.AddProduct(categoryIndex, name);
                return "OK";
            }
            catch (Exception ex)
            {
                return "BAD";
            }
            
        }
    }
}
