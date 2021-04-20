using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsWebApp
{
    public class PaginationHelper
    {
        // рассчёт skip-а при пагинации
        public static int CalculateOffset(int pageNumber, int rows)
        {
            int offset = 0;
            if (pageNumber < 1)
                pageNumber = 1;

            if (rows < 1)
                rows = 20;
            offset = (pageNumber - 1) * rows;
            return offset;
        }

        /// <summary>
        /// Рассчёт количества страниц в запросе исходя из количества строк на странице
        /// </summary>
        /// <typeparam name="T">тип IQueryable</typeparam>
        /// <param name="q">Запрос IQueryable</param>
        /// <param name="itemOnPageCount">Количество строк на странице</param>
        /// <returns></returns>
        public static int GetRequestPagesCount<T>(IQueryable<T> q, int itemOnPageCount)
        {
            int count = q.Count();
            return (int)Math.Ceiling((decimal)count / itemOnPageCount);
        }
    }
}
