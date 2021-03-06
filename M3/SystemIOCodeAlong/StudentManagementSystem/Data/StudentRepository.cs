﻿using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Data
{
    public class StudentRepository
    {
        private string _filePath;

        public StudentRepository(string filePath)
        {
            _filePath = filePath;
        }

        // list, add, edit, delete
        public ListStudentResponse List()
        {

            ListStudentResponse response = new ListStudentResponse();
            response.Success = true;

            response.Students = new List<Student>();

            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    sr.ReadLine();
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Student newStudent = new Student();

                        string[] columns = line.Split(',');

                        newStudent.FirstName = columns[0];
                        newStudent.LastName = columns[1];
                        newStudent.Major = columns[2];
                        newStudent.GPA = decimal.Parse(columns[3]);

                        response.Students.Add(newStudent);
                    }
                }
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
               
            
            return response;
        }

        public void add(Student student)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, true))
            {
                string line = CreateCsvForStudent(student);

                sw.WriteLine(line);
            }
        }

        public void Edit(Student student, int index)
        {
            var response = List();

            response.Students[index] = student;

            CreateStudentFile(response.Students);
        }

        public void Delete(int index)
        {
            var response = List();
            response.Students.RemoveAt(index);

            CreateStudentFile(response.Students);
        }

        private string CreateCsvForStudent(Student student)
        {
            return string.Format("{0},{1},{2},{3}", student.FirstName,
                    student.LastName, student.Major, student.GPA.ToString());
        }

        private void CreateStudentFile(List<Student> students)
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }

            using(StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine("FirstName,LastName,Major,GPA");
                foreach (var student in students)
                {
                    sw.WriteLine(CreateCsvForStudent(student));
                }
            }
        }
    }
}
