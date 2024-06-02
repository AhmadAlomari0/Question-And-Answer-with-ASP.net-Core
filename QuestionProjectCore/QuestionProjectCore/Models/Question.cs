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
        [StringLength(maximumLength:300,ErrorMessage ="Sorry, maximum length is 300", MinimumLength=5)]
        public string TheQuestion { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public Category? Category { get; set; }
        public ICollection<Answer>? Answers { get; set; }
    }
}
