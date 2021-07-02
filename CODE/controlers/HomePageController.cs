using LibraryUnivercity.interfaces;
using LibraryUnivercity.entity;
using LibraryUnivercity.model;
using LibraryUnivercity.repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace LibraryUnivercity.controlers
{
    public class HomePageController : Controller
    {
        public readonly ICUDlibrarian librarian;
        public readonly ICUDuser user;
        public readonly ILogger<HomePageController> _logger;
        public HomePageController(ICUDlibrarian librarian, ICUDuser user , ILogger<HomePageController> _logger)
        {
            this.librarian = librarian;
            this.user = user;
            this._logger = _logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("you are in Index action!");
            return Ok("wellcome");
        }
        [HttpPost]
        public IActionResult LogInAdmin([FromBody] LibrarianModel librarianModel)
        {
            _logger.LogInformation("you are in LogInAdmin!!");
            if (ModelState.IsValid)
            {
                return View(librarian.identityconfirmation(librarianModel));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        [HttpPost]
        public IActionResult LogInUser([FromBody] UserModel userModel)
        {
            _logger.LogInformation("you are in LogInAdmin!!");
            if (ModelState.IsValid)
            {
                return View(user.identityconfirmation(userModel));
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
