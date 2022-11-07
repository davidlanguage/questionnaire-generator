using Microsoft.AspNetCore.Mvc;

namespace QuestionnaireGenerator.Controllers
{
    public class QuestionsController : Controller
    {
        [HttpGet]
        [Route("[controller]/{userId}")]
        public IActionResult GetQuestion()
        {
            //display the question
            //Question q = new Question();
            return Content("${0} sees the next question", "pepe");
        }

        [HttpPost]
        [Route("[controller]/{userId}")]
        public IActionResult SendAnswer()
        {
            // send the answer to the database
            // display the next question
            // if no more questions, display results
            return View();
        }


    }
}
