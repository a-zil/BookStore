﻿using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult GetAllBooks()
        {
            return View();
        }
    }
}