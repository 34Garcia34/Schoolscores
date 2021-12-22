namespace Schoolscores.Models.ViewModels
{
    public class HomeVM
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public IEnumerable<Examscores>? Studentscores { get; set; }



        public List<string> Labels { get; set; }
        public List<decimal> Values { get; set; }

    }
}
