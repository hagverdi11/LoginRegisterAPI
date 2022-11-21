using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Book
{
    public class BookListDto
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public int Page { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
