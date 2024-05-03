using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionProjectCore.Models
{
    public class Answer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public int Like { get; set; }
        [Required]
        public string TheAnswer { get; set; }
        [Required]
        [ForeignKey("member")]
        public int MemberID { get; set; }
        [Required]
        public Member member { get; set; }
        [ForeignKey("question")]
        [Required]
        public int QuestionID { get; set; }
        [Required]
        public Question question { get; set; }
    }
}
