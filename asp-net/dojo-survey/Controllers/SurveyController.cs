using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Survey.Controllers
{
    public class SurveyController : Controller
    {

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(string name, string language, string location, string comment)
        {
            return RedirectToAction("Result", new { name = name, language = language, location = location, comment = comment });
        }

        [HttpGet]
        [Route("results")]
        public IActionResult Result(string name, string language, string location, string comment)
        {
            ViewBag.name = name;
            ViewBag.lang = language;
            ViewBag.loc = location;
            ViewBag.com = comment;
            return View("results");
        }

    }
}
