using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionnaireGenerator.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string QuestionStatement { get; set; } = "Unknown question";
        public List<Answer> AnswerOptions { get; set; } = new List<Answer>();
        public bool disabled { get; set; } = false;
    }
}
