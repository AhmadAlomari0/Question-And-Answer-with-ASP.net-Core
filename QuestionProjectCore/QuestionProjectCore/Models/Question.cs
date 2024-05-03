using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionProjectCore.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public int Like { get; set; } = 0;
        [Required]
        public string TheQuestion { get; set; }
        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        //[ForeignKey("Member")]
        [Required]
        public string UserID { get; set; }
        [Required]
        //public Member Member { get; set; }
        public Category? Category { get; set; }
        public ICollection<Answer>? Answers { get; set; }
    }
}
