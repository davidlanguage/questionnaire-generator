using Microsoft.AspNetCore.Mvc;
using QuestionnaireGenerator.ViewModels;
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
            NextQuestion question = new NextQuestion();
            question.QuestionStatement = "¿Hola?";
            question.AnswerOptions = new List<string>();
            question.AnswerOptions.Add("A");
            question.AnswerOptions.Add("B");
            question.AnswerOptions.Add("C");

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
