using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Word.Controllers
{
    public class WordController : Controller
    {

        public static string WordGenerator()
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string word = "";
            Random rand = new Random();
            for (int i = 0; i < 14; i++)
            {
                word += alpha[rand.Next(36)];
            }
            return word;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.count = HttpContext.Session.GetInt32("count");
            ViewBag.word = HttpContext.Session.GetString("word");
            return View("index");
        }

        [HttpGet]
        [Route("generate")]
        public IActionResult Generate()
        {
            HttpContext.Session.SetString("word", WordGenerator());
            int? count = HttpContext.Session.GetInt32("count");
            if (count == null)
            {
                count = 0;
            }
            HttpContext.Session.SetInt32("count", (int)count + 1);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}