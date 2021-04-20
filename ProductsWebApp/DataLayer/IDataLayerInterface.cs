using ProductsWebApp.DB;
using ProductsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsWebApp.DataLayer
{
    public interface IDataLayerInterface
    {
        IQueryable<Category> GetCategories();
        ProductsTable GetProductsTable(int categoryIdFilterValue=0, int currentPage=1, int rows=20);
        void DeleteProduct(int id);
        void AddProduct(int categoryId, string name);
    }
}
