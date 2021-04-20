using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsWebApp.Interfaces
{
    public interface IPaginable
    {
        /// <summary>
        /// Количество страниц выборки
        /// </summary>
        int PageCount { get; set; }
        /// <summary>
        /// Текущая страница
        /// </summary>
        int CurrentPage { get; set; }
    }
}
