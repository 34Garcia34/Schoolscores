using System.ComponentModel.DataAnnotations;

namespace Schoolscores.Models
{
    public class Examscores
    {
        [Key]
        public int ExamId { get; set; }  
        public string TearcherId { get; set; }
        public string StudentId { get; set; }
        public decimal Testscore { get; set; }
    }
}
