using BookManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManager.Controllers
{
    public class BookController : Controller
    {
        
        public ActionResult HienThiBook()
        {
            var danhsachBook = new DanhSachBook();
            var dsBook = danhsachBook.listBook;
            return View(dsBook);
        }
        
        public ActionResult ThemMoiBook() { 
            return View();
          
        }
        
        public ActionResult SaveBook(int bookID, string bookName, DateTime ngayXuatBan, string author)
        {
            var danhsachBook = new DanhSachBook();
            danhsachBook.listBook.Add(new Book()
            {
                BookID = bookID,
                BookName = bookName,
                NgayXuatBan = ngayXuatBan,
                Author = author,
            });
            return RedirectToAction("HienThiBook");
        }




    }
}