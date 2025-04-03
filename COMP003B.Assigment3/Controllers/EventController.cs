using Microsoft.AspNetCore.Mvc;
using COMP003B.Assigment3.Models;

namespace COMP003B.Assigment3.Controllers
{
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]

        public IActionResult Register(string eventCode)
        {
           
            return View();
        }

        [HttpGet("register")]

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register([FromForm] EventRegistration registration)
        {
            if(!ModelState.IsValid)
            {
                return View(registration);
            }
            return RedirectToAction("Success", registration);
        }
        [Route("success")]

        public IActionResult Success(EventRegistration registration)
        {
            return View(registration);
        }

        
    }
}
