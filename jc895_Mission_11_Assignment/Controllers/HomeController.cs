using jc895_Mission_11_Assignment.Models;
using jc895_Mission_11_Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq; // Make sure you're using System.Linq to use .ToArray()

namespace jc895_Mission_11_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepository; // Ensure this matches the corrected interface name

        public HomeController(IBookRepository temp) // This should be IBooksRepository if you've followed the earlier advice
        {
            _bookRepository = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var blah = new ProjectListViewModel
            {
                Books = _bookRepository.Books
                .Skip((pageNum-1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookRepository.Books.Count()
                }
            };
            return View(blah); // Pass the books to the view
        }
    }
}