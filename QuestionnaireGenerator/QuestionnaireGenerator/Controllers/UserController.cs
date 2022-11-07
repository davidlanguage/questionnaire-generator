using Microsoft.AspNetCore.Mvc;

namespace QuestionnaireGenerator.Controllers
{
    [Route("[controller]/{id}")]
    public class UserController : Controller
    {
        public IActionResult Index(int id)
        {
            return Content("This is the user results page for " + id);
        }
    }
}
