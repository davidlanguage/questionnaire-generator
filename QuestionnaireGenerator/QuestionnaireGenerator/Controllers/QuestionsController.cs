using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace QuestionnaireGenerator.Controllers
{
    public class QuestionsController : Controller
    {

        [HttpGet]
        [Route("[controller]/{userId}")]
        public IActionResult GetQuestion()
        {

            // TODO hardcoded viewmodel
            Models.Question question = new Models.Question();
            question.QuestionStatement = "¿Hola?";
            question.AnswerOptions = new List<Models.Answer>();
            question.AnswerOptions.Add(new Models.Answer());
            question.AnswerOptions.Add(new Models.Answer());
            question.AnswerOptions.Add(new Models.Answer());

            return View("NextQuestion", question);
        }

        [HttpPost]
        [Route("[controller]/{userId}/q/{questionId}")]
        public IActionResult SendAnswer(int userId, int questionId)
        {
            // save the answer to the database, then return the redirect

            return RedirectToAction("GetQuestion", new { userId = userId, });
        }


    }
}
