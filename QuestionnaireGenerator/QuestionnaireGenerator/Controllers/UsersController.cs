using Microsoft.AspNetCore.Mvc;
using QuestionnaireGenerator.Models;
using QuestionnaireGenerator.ViewModels;

namespace QuestionnaireGenerator.Controllers
{
    [Route("[controller]/{id}")]
    public class UsersController : Controller
    {
        [Route("")]
        public IActionResult Index(int id)
        {
            /*
            UserData user = new UserData();
            user.Id = 1;
            user.Affinities.Add(1);
            user.Affinities.Add(2);
            user.Affinities.Add(3);
            user.Affinities.Add(4);
            user.Affinities.Add(5);
            user.Email = "123@123.com";*/
            //Return a view model
            return View(new UserData());
        }
    }
}
