using Microsoft.AspNetCore.Mvc;
using QuestionnaireGenerator.ViewModels;

namespace QuestionnaireGenerator.Controllers
{
    public class QuestionsController : Controller
    {
        [HttpGet]
        [Route("[controller]/{userId}")]
        public IActionResult GetQuestion()
        {
            NextQuestion question = new NextQuestion();
            question.QuestionStatement = "¿Hola?";
            question.AnswerOptions = new List<string>();
            question.AnswerOptions.Add("A");
            question.AnswerOptions.Add("B");
            question.AnswerOptions.Add("C");
            //display the question
            //Question q = new Question();
            return View("NextQuestion", question);
        }

        [HttpPost]
        [Route("[controller]/{userId}")]
        public IActionResult SendAnswer()
        {
            // send the answer to the database
            // display the next question
            // if no more questions, display results
            var req = Request.Body;
            Console.WriteLine(req);
            return View();
        }


    }
}
