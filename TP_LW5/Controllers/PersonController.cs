using Microsoft.AspNetCore.Mvc;
using TP_LW5.Models;

namespace TP_LW5.Controllers
{
    public class PersonController : Controller
    {
        private List<Person> _people;

        public PersonController()
        {
            _people = new List<Person>();
        }

        public IActionResult Index()
        {
            return View(_people);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Person person)
        {
            _people.Add(person);
            HttpContext.Response.Cookies.Append("CurrentPersonIndex", _people.Count.ToString());
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var person = _people[id];
            HttpContext.Response.Cookies.Append("CurrentPersonIndex", id.ToString());
            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            var id = int.Parse(HttpContext.Request.Cookies["CurrentPersonIndex"]);
            _people[id] = person;
            return RedirectToAction("Index");
        }
    }
}
