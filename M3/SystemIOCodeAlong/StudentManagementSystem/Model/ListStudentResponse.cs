﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    public class ListStudentResponse
    {
        public List<Student> Students { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
