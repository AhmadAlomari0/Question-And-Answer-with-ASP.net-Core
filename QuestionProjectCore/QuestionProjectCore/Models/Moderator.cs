namespace QuestionProjectCore.Models
{
    public class Moderator
    {
        public int Id { get; set; }
        public string ModeratorName { get; set; }
        public string? ModeratorPhone { get; set; }
        public int? Moderatormail { get; set; }
        public int? ModeratorAge { get; set; }
        public decimal? ModeratorSalary { get; set; }
    }
}
