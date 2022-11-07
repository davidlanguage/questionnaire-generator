using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuestionnaireGenerator.Models
{
    public class UserData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        public double AFFINITY_DATA { get; set; }
        public double AFFINITY_LOGISTICS { get; set; }
        public double AFFINITY_IDENTITY_VALIDATION { get; set; }
        public double AFFINITY_FIDELIZATION { get; set; }
        public double AFFINITY_PAYMENTS { get; set; }
        public List<Response> Responses { get; set; } = new List<Response>();

    }
}
