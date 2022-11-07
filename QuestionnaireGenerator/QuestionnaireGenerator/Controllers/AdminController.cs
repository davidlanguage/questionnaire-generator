using Microsoft.AspNetCore.Mvc;

namespace QuestionnaireGenerator.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            // login
            return View();
        }

        [HttpGet]
        [Route("[controller]/questions/{id}")]
        public IActionResult questions()
        {
            // check if there is an auth cookie

            // send the specific question to the admin
            return Content("GET the question with id= ${id}");
        }

        [HttpPost]
        [Route("[controller]/questions")]
        public IActionResult PostSpecificQuestion()
        {
            // check if there is an auth cookie

            // send the specific question to be saved

            // 201 if succesful (with the location of the created question in headers)
            // 400 if wrong format
            return Content("POST the question with id= ${id}");
        }

        [HttpPatch]
        [Route("[controller]/questions/{id}")]
        public IActionResult PatchSpecificQuestion()
        {
            // check if there is an auth cookie

            // send the specific question to be saved

            // no response if succesful
            // 400 if wrong format
            return Content("PATCH the question with id= ${id}");
        }
    }
}
