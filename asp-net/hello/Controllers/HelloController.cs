using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        [Route("json")]
        public JsonResult Example()
        {
            var AnonObject = new {
                FirstName = "Raz",
                LastName = "Aquato",
                Age = 10
            };
            return Json(AnonObject);
        }
    }
}