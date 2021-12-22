using Microsoft.AspNetCore.Mvc.Rendering;

namespace Schoolscores.Models.ViewModels
{
    public class ExamVM
    {
        public Exam Exams { get; set; }
        public IEnumerable<SelectListItem> TeachersList { get; set; }
        public IEnumerable<SelectListItem> StudentList { get; set; }
    }
}

