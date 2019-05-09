﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp304.Models
{
    public class Course
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Name { get; set; }
        [StringLength(300)]
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool isActive { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public IEnumerable<StudentCourse> StudentCourses { get; set; }
    }
}
