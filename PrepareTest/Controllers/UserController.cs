using Microsoft.AspNetCore.Mvc;
using PrepareTest.Models;

namespace PrepareTest.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit([FromBody] User user)
        {
            return Ok($"Success {user.Name}");
        }

        [HttpGet]
        public IActionResult getUser([FromQuery] int id, [FromQuery] string name)
        {
            return Ok($"id = {id}, name = {name}");
        }

        [HttpGet("Detail/{id}")]
        public IActionResult getUserRoute([FromRoute] int id)
        {
            return Ok($"id = {id}");
        }

        [HttpGet]
        public IActionResult getToken([FromHeader] string token)
        {
            return Ok($"token = {token}");
        }



    }
}
