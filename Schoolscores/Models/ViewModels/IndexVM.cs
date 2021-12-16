namespace Schoolscores.Models.ViewModels
{
    public class IndexVM
    {
        public IEnumerable<Teacher>? Teachers { get; set; }
        public IEnumerable<Student>? Students { get; set; }
        public IEnumerable<Examscores>? ExamScores { get; set; }
        public List<string> Labels { get; set; }
        public List<decimal> Values { get; set; }
    }
}
