using ProductsWebApp.DB;
using ProductsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsWebApp.DataLayer
{
    public class DBHelper: IDataLayerInterface
    {
        private readonly ProductsContext _context;

        public DBHelper(ProductsContext context)
        {
            this._context = context;
        }

        public void AddProduct(int categoryId, string name)
        {
            Product product = new Product()
            {
                CategoryId = categoryId,
                Name = name
            };
            _context.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public IQueryable<Category> GetCategories()
        {
            return _context.Categories;
        }

        public ProductsTable GetProductsTable(int categoryIdFilterValue=0, int currentPage = 1, int rows = 20)
        {
            int skip = PaginationHelper.CalculateOffset(currentPage, rows);

            ProductsTable productsTable = new ProductsTable();
            IQueryable<ProductModel> productsTableQuery = null;
            switch (categoryIdFilterValue)
            {
                case 0:
                    productsTableQuery = from p in _context.Products
                                         join cLetf in _context.Categories on p.CategoryId equals cLetf.Id into ctemp
                                         from c in ctemp.DefaultIfEmpty()
                                         select new ProductModel()
                                         {
                                             Id = p.Id,
                                             CategoryType = c.Name,
                                             Name = p.Name
                                         };

                    break;
                default:
                    productsTableQuery = from p in _context.Products
                                         join cLetf in _context.Categories on p.CategoryId equals cLetf.Id into ctemp
                                         from c in ctemp.DefaultIfEmpty()
                                         where p.CategoryId == categoryIdFilterValue
                                         select new ProductModel()
                                         {
                                             Id = p.Id,
                                             CategoryType = c.Name,
                                             Name = p.Name
                                         };
                    break;
            }

            productsTable.PageCount = PaginationHelper.GetRequestPagesCount<ProductModel>(productsTableQuery, rows);
            productsTable.ProductsList = productsTableQuery.Skip(skip).Take(rows).ToList();
            productsTable.CurrentPage = currentPage;
            return productsTable;
        }
    }
}
