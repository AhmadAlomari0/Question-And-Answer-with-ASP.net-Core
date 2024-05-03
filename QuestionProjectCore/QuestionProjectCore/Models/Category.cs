using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuestionProjectCore.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [DisplayName("Category")]
        [Required]
        public string CategoryName { get; set; }
    }
}
