using Microsoft.AspNetCore.Mvc;
using QuestionnaireGenerator.Models;

namespace QuestionnaireGenerator.Controllers
{
    public class AdminController : Controller
    {

        private Dictionary<int, Question> questions = new Dictionary<int, Question>();

        public IActionResult Index()
        {
            // login
            return View();
        }

        [HttpGet]
        [Route("[controller]/questions/{id}")]
        public IActionResult GetSpecificQuestion(int id)
        {
            // check if there is an auth cookie

            if(!questions.ContainsKey(id)) return NotFound();
            return Json(questions[id]);
        }

        [HttpPost]
        [Route("[controller]/questions")]
        public IActionResult PostSpecificQuestion(Models.Question q)
        {
            // check if there is an auth cookie

            if(questions.ContainsKey(q.Id)) return BadRequest();
            questions[q.Id] = q;
   
            return CreatedAtRoute("GetSpecificQuestion", q.Id);
        }

        [HttpPatch]
        [Route("[controller]/questions/{id}")]
        public IActionResult PatchSpecificQuestion(int id)
        {
            // check if there is an auth cookie

            // send the specific question to be saved

            // no response if succesful
            // 400 if wrong format
            Models.Question q;

            return Ok();
        }
    }
}
