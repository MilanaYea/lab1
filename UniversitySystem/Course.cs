using System;
using System.Collections.Generic;

namespace UniversitySystem
{
    public abstract class Course
    {
        public string Name { get; private set; }
        protected List<Student> students = new List<Student>();
        protected Teacher teacher;

        public Course(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void SetTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public abstract void PrintInfo();
    }
}