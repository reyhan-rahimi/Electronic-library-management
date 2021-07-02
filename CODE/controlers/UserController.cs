using Microsoft.AspNetCore.Mvc;
using LibraryUnivercity.entity;
using LibraryUnivercity.interfaces;
using LibraryUnivercity.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace LibraryUnivercity.controlers
{
    public class UserController : Controller
    {
        public readonly ILogger<UserController> _logger;
        public readonly ICUDuser user;
        public UserController(ILogger<UserController> _logger  , ICUDuser user)
        {
            this._logger = _logger;
            this.user = user;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("you are in Index action!");
            return Ok("wellcome"); 
        }
        [HttpPost]
        public IActionResult SearchBook([FromBody] BookModel bookModel)
        {
            _logger.LogInformation("you are in LogInAdmin CreateAccount!!");
            if (ModelState.IsValid)
            {
                return View(user.SearchBook(bookModel));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        [HttpPost]
        public IActionResult ShowBorrowList([FromBody] UserModel userModel)
        {
            _logger.LogInformation("you are in LogInAdmin CreateAccount!!");
            if (ModelState.IsValid)
            {
                return View(user.ShowBorrowList(userModel));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        [HttpPost]
        public IActionResult AddTime( [FromBody] UserModel userModel, BookModel bookModel)
        {
            _logger.LogInformation("you are in LogInAdmin CreateAccount!!");
            if (ModelState.IsValid)
            {
                return View(user.AddTime(userModel, bookModel));
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
