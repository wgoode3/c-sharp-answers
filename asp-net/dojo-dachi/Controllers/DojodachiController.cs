using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dojodachi;

namespace Dojodachi.Controllers
{
    public class DojodachiController : Controller
    {
        public static Dojodachi dojodachi = new Dojodachi();

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.message = TempData["msg"];
            ViewBag.happiness = dojodachi.happiness;
            ViewBag.fullness = dojodachi.fullness;
            ViewBag.energy = dojodachi.energy;
            ViewBag.meals = dojodachi.meals;
            return View("index");
        }

        [HttpGet]
        [Route("dojodachi/{act}")]
        public IActionResult Action(String act)
        {
            if (act == "feed")
            {
                TempData["msg"] = dojodachi.Feed();
            }
            else if (act == "play")
            {
                TempData["msg"] = dojodachi.Play();
            }
            else if (act == "work")
            {
                TempData["msg"] = dojodachi.Work();
            }
            else if (act == "sleep")
            {
                TempData["msg"] = dojodachi.Sleep();
            }

            if (dojodachi.energy <= 0)
            {
                TempData["msg"] = "Your dojodachi died from lack of energy!";
                return RedirectToAction("EndGame");
            }
            else if (dojodachi.happiness <= 0)
            {
                TempData["msg"] = "Your dojodachi died from unhappiness!";
                return RedirectToAction("EndGame");
            }
             else if (dojodachi.fullness <= 0)
            {
                TempData["msg"] = "Your dojodachi died from starvation!";
                return RedirectToAction("EndGame");
            }
            else if (dojodachi.happiness > 99 && dojodachi.energy > 99 && dojodachi.fullness > 99)
            {
                TempData["msg"] = "Your dojodachi loves you, you win forever!";
                return RedirectToAction("EndGame");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("endgame")]
        public IActionResult EndGame()
        {
            ViewBag.message = TempData["msg"];
            ViewBag.happiness = dojodachi.happiness;
            ViewBag.fullness = dojodachi.fullness;
            ViewBag.energy = dojodachi.energy;
            ViewBag.meals = dojodachi.meals;
            return View("endgame");
        }

        [HttpGet]
        [Route("reset")]
        public IActionResult Reset()
        {
            dojodachi = new Dojodachi();
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}