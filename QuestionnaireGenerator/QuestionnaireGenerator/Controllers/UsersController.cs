using Microsoft.AspNetCore.Mvc;
using QuestionnaireGenerator.Models;

namespace QuestionnaireGenerator.Controllers
{
    [Route("[controller]/{id}")]
    public class UsersController : Controller
    {
        [Route("")]
        public IActionResult Index(int id)
        {
            UserData user = new UserData();
            Response res1 = new Response();
            res1.ResponseGiven = 50;
            res1.UserId = id;
            res1.QuestionId = 23;
            Response res2 = new Response();
            res1.ResponseGiven = 74;
            res1.UserId = id;
            res1.QuestionId = 13;
            Response res3 = new Response();
            res1.ResponseGiven = 25;
            res1.UserId = id;
            res1.QuestionId = 33;

            user.Id = id;
            user.Email = "pepe@gmail.com";
            user.Responses.Add(res1);
            user.Responses.Add(res2);
            user.Responses.Add(res3);
            //Through the ide we get all the info from the database

            return View(user);
        }
    }
}
