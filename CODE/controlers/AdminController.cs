using LibraryUnivercity.entity;
using LibraryUnivercity.interfaces;
using LibraryUnivercity.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.controlers
{
    public class AdminController : Controller
    {
        public readonly ICUDlibrarian librarian;
        public readonly ILogger<AdminController> _logger;
        public AdminController(ICUDlibrarian librarian , ILogger<AdminController> _logger)
        {
            this.librarian = librarian;
            this._logger = _logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("you are in Index action!");
            return Ok("wellcome");
        }
        [HttpPost]
        public IActionResult CreateAccount([FromBody] User user)
        {
            _logger.LogInformation("you are in LogInAdmin CreateAccount!!");
            if (ModelState.IsValid)
            {
                return View(librarian.CreateAccount(user));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        [HttpPost]
        public IActionResult AddBook([FromBody] Books book)
        {
            _logger.LogInformation("you are in LogInAdmin AddBook!!");
            if (ModelState.IsValid)
            {
                return View(librarian.AddBook(book));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        [HttpPost]
        public IActionResult DeleteAccount([FromBody] UserModel userModel)
        {
            _logger.LogInformation("you are in LogInAdmin DeleteAccount!!");
            if (ModelState.IsValid)
            {
                return View(librarian.DeleteAccount(userModel));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }

        }
        [HttpPost]
        public IActionResult DeleteBook([FromBody] BookModel bookModel)
        {
            _logger.LogInformation("you are in LogInAdmin DeleteBook!!");
            if (ModelState.IsValid)
            {
                return View(librarian.DeleteBook(bookModel));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        [HttpPost]
        public IActionResult BorrowBook([FromBody] UserModel userModel,[FromBody] BookModel bookModel)
        {
            _logger.LogInformation("you are in LogInAdmin BorrowBook!!");
            if (ModelState.IsValid)
            {
                return View(librarian.BorrowBook(userModel,bookModel));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        [HttpPost]
        public IActionResult ReturnBook( [FromBody] UserModel userModel, [FromBody] BookModel bookModel)
        {
            _logger.LogInformation("you are in LogInAdmin ReturnBook!!");
            if (ModelState.IsValid)
            {
                return View(librarian.ReturnBook(userModel , bookModel));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        [HttpPost]
        public IActionResult UpdateAccount([FromBody] UserModel userModel,[FromBody] int choose)
        {
            _logger.LogInformation("you are in LogInAdmin UpdateAccount!!");
            if (ModelState.IsValid)
            {
                return View(librarian.UpdateAccount(userModel, choose));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        public IActionResult CreateOrder( [FromBody] BookModel bookModel)
        {
            _logger.LogInformation("you are in LogInAdmin CreateOrder!!");
            if (ModelState.IsValid)
            {
                return View(librarian.CreateOrder(bookModel));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }


    }
}
