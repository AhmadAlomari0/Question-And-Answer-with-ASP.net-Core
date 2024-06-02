using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionProjectCore.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string UserId { get; set; }
        //[ForeignKey("Member")]
        //public int memberID { get; set; }
        //public Member Member { get; set; }
    }
}
