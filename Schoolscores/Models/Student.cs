﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Schoolscores.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public decimal examscore { get; set; }


        public Teacher? Teachers { get; set; }



    }
}
