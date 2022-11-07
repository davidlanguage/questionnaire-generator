namespace QuestionnaireGenerator.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionStatement { get; set; } = "Unknown question";
        public IList<string> AnswerOptions { get; set; } = new List<string>();
    }
}
