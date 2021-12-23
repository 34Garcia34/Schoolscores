using System.ComponentModel.DataAnnotations;

namespace Schoolscores.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        [Display(Name = "Student")]
        public int StudentId { get; set; }
        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }

        public char Grade { get; set; } 

        public decimal Examscores { get; set;}


    }
}
