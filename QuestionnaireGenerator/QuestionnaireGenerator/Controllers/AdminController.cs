using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuestionnaireGenerator.Database;
using QuestionnaireGenerator.Models;

namespace QuestionnaireGenerator.Controllers
{
    public class AdminController : Controller
    {

        private Dictionary<int, Question> questions = new Dictionary<int, Question>();
        private readonly DBInteractor db = new DBInteractor();

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

            Question? q = db.Questions.FindAsync(id).Result;
            if(q == null) return NotFound();
            return Json(q);
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
                db.Add<Question>(q);
                db.SaveChanges();
                return Created($"/questions/{q.Id}", null);

            } catch(Exception e)
            {
                return Content(e.StackTrace);
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
