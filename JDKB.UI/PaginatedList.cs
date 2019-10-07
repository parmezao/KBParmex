using System;
using System.Collections.Generic;
using System.Linq;

namespace JDKB.UI
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public int TotalItens { get; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            TotalItens = count;

            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool FirstPage => (PageIndex == 1);

        public bool LastPage => (PageIndex == TotalPages || TotalPages == 0);

        public bool HasPreviousPage => (PageIndex > 1);

        public bool HasNextPage => (PageIndex < TotalPages);

        public static PaginatedList<T> Create(IQueryable<T> source, int pageIndex, int pageSize, int total = 0)
        {
            var count = total; //source.Count(); 
            // Paginação está sendo feita diretamente na Base de Dados
            //var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            
            var items = source.ToList();

            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}
