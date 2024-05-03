using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace QuestionProjectCore.Models
{
    [Index(nameof(UserName), nameof(PhoneNumber), IsUnique = true)]
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Username cannot be null")]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "PhoneNumber cannot be null")]
        [DisplayName("Phonenumber")]
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        public string Country { get; set; }
        public string? ImagePath { get; set; }

        [NotMapped]
        public IFormFile ClientFile { get; set; }

        public ICollection<Answer>? answers { get; set; }
        public ICollection<Question>? questions { get; set; }
    }
}
