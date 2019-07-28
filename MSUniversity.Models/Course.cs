﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUniversity.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Credit { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public CourseSemester Semester { get; set; }
    }
    public enum CourseSemester
    {
       SelectSemester,
        First,
        Second,
        Third,
        Four,
        Five,
        Six,
        Seven,
        Eight
    }
}
