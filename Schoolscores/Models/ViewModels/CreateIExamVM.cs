using Microsoft.AspNetCore.Mvc.Rendering;

namespace Schoolscores.Models.ViewModels
{
    public class CreateIExamVM
    {
        public Student Student { get; set; }
        public IEnumerable<SelectListItem> StudentList { get; set; }

        public Teacher teacher { get; set; }
        public IEnumerable<SelectListItem> TeacherList { get; set; }


    }
}
