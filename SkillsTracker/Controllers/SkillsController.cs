using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace SkillsTracker.Controllers
{
    [Route("/skills/")]
    public class SkillsController : Controller
    {
        // GET: /skills/
        [HttpGet]
        public IActionResult Index()
        {
            return Content("<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn:</h2>" +
                "<ol><li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li></ol>", "text/html");
        }

        //Get: /skills/form/
        [HttpGet]
        [Route("/skills/form/")]
        public IActionResult SkillsForm()
        {
            string html = "<form method='post' action='/skills/form/'>" +
                "Date:" +
                "<br>" +
                "<input type='date' name='date' placeholder='yyyy-mm-dd' />" +
                "<br>" +
                "C#:" +
                "<br>" +
                "<select name='cSharpSkill'>" +
                    "<option value='Learning Basics'>Learning basics</option>" +
                    "<option value='Unit Testing'>Unit testing</option>" +
                    "<option value='Inheritance'>Inheritance</option>" +
                    "<option value='Polymorphism'>Polymorphism</option>" +
                    "<option value='MVC'>MVC</option>" +
                    "<option value='SQL'>SQL</option></select>" +
                "<br>" +
                "JavaScript:" +
                "<br>" +
                "<select name='jsSkill'>" +
                    "<option value='Learning Basics'>Learning basics</option>" +
                    "<option value='Unit Testing'>Unit testing</option>" +
                    "<option value='Functions'>Functions</option>" +
                    "<option value='Modules'>Modules</option>" +
                    "<option value='Classes'>Classes</option>" +
                    "<option value='Angular'>Angular</option></select>" +
                "<br>" +
                "Python:" +
                "<br>" +
                "<select name='pythonSkill'>" +
                    "<option value='Learning Basics'>Learning basics</option>" +
                    "<option value='Web Frameworks'>Web frameworks</option>" +
                    "<option value='Object oriented programming'>Object oriented programming</option>" +
                    "<option value='Tensorflow'>Tensorflow</option></select>" +
                "<br>" +
                "<input type='submit' value='Submit' />" +
                "</form>";
            return Content(html, "text/html");
        }

        //Post: /skills/form/
        [HttpPost]
        [Route("/skills/form/")]
        public IActionResult DisplaySkillsChosen(string date, string cSharpSkill, string jsSkill, string pythonSkill)
        {
            string html = "<h1>" + date + "</h1>" +
                "<ol>" +
                    "<li>C#: " + cSharpSkill + "</li>" +
                    "<li>JavaScript: " + jsSkill + "</li>" +
                    "<li>Python: " + pythonSkill + "</li>";
            return Content(html, "text/html");
        }
  
    }
}
