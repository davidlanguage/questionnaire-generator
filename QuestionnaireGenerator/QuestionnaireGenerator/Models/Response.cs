using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionnaireGenerator.Models
{
    public class Response
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [ForeignKey("UserData")]
        public int UserId { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public int ResponseGiven { get; set; }
    }
}
