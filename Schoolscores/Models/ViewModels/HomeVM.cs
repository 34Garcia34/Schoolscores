namespace Schoolscores.Models.ViewModels
{
    public class HomeVM
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public List<Exam> Exams { get; set; }
        public List<string> Labels { get; set; }
        public List<decimal> Values { get; set; }

    }
}
