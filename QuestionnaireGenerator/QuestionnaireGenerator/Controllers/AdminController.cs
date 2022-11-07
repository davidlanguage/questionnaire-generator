using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

            return Content(questions[1].QuestionStatement);
            return Content(questions.ToString());
            return Content(JsonConvert.SerializeObject(questions[id]));
            if(!questions.ContainsKey(id)) return NotFound();
            return Json(questions[id]);
        }

        [HttpPost]
        [Route("[controller]/questions")]
        public IActionResult PostSpecificQuestionAsync()
        {

            // check if there is an auth cookie

            String raw = new StreamReader(HttpContext.Request.Body).ReadToEndAsync().Result;
            try
            {
                Question? q = JsonConvert.DeserializeObject<Question>(raw);
                questions[q.Id] = q;
                return Created($"/questions/{q.Id}", null);

            } catch(Exception e)
            {
                return BadRequest();
            }
            //if (q != null) 
        }

        [HttpDelete]
        [Route("[controller]/questions/{id}")]
        public IActionResult DeleteSpecificQuestion(int id)
        {
            // check if there is an auth cookie

            if (questions.ContainsKey(id)) return BadRequest();
            questions.Remove(id);

            return Ok() ;
        }

        /*
        [HttpPatch]
        [Route("[controller]/questions/{id}")]
        public IActionResult PatchSpecificQuestion(int id, Question q)
        {
            // check if there is an auth cookie

            // send the specific question to be saved

            // no response if succesful
            // 400 if wrong format
            Models.Question q;

            return Ok();
        }
        */
    }
}
