using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookManager.Models
{
    public class Book
    {
        public int BookID {  get; set; }
        public string BookName { get; set; }
        public DateTime NgayXuatBan { get; set; }
        public string Author { get; set; }
        
    }
}