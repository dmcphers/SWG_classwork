﻿using StudentManagementSystem.Data;
using StudentManagementSystem.Helpers;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Workflows
{
    public class ListStudentWorkflow
    {
        public void Execute()
        {
            StudentRepository repo = new StudentRepository(Settings.FilePath);
            List<Student> students = repo.List();

            Console.Clear();
            Console.WriteLine("Student List");

            ConsoleIO.PrintStudentListHeader();
           
            foreach (var student in students)
            {
                Console.WriteLine(ConsoleIO.StudentLineFormat, student.LastName + "," + student.FirstName, student.Major, student.GPA);
            }
            Console.WriteLine();
            Console.WriteLine(ConsoleIO.SeparatorBar);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
