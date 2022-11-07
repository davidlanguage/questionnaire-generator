using QuestionnaireGenerator.Models;

namespace QuestionnaireGenerator.ViewModels
{
    public class UserData
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public IList<double> Affinities { get; set; } = new List<double>() {1,2,3,4,5 };
        public IList<Response> Responses { get; set; } = new List<Response>();

    }
}
