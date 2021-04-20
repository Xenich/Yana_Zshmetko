using Microsoft.AspNetCore.Mvc.Rendering;
using ProductsWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsWebApp.Models
{
    public class ProductsViewModel
    {
        public SelectList Filter { get; set; }
        public SelectList ItemsCountOnPage { get; set; }
        public ProductsTable ProductsTable = new ProductsTable();
    }

    public class ProductsTable : IPaginable
    {
        [Display(Name = "Всего страниц")]
        public int PageCount { get; set; }
        [Display(Name = "Текущая страница")]
        public int CurrentPage { get; set; }

        public List<ProductModel> ProductsList = new List<ProductModel>();
    }

    public class ProductModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Наименование товара")]
        public string Name { get; set; }
        [Display(Name = "Категория")]
        public string CategoryType { get; set; }
    }
}
