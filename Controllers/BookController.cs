using BookListRazorPages.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazorPages.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Json(new { data = _db.Book.ToList() });
        }

        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _db.Book.FirstOrDefault(x => x.Id == id);
        }
    }
}