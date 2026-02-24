using System;
using System.Collections.Generic;

namespace UniversitySystem
{
    public class University
    {
        private List<Course> courses = new List<Course>();
        private List<Teacher> teachers = new List<Teacher>();

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
            Console.WriteLine("Преподаватель добавлен.");
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine("Курс добавлен.");
        }

        public void RemoveCourse(string courseName)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Name == courseName)
                {
                    courses.RemoveAt(i);
                    Console.WriteLine("Курс удалён.");
                    return;
                }
            }
            Console.WriteLine("Курс не найден.");
        }

        public void AssignTeacherToCourse(string courseName, string teacherName)
        {
            Course course = FindCourse(courseName);
            Teacher teacher = FindTeacher(teacherName);

            if (course != null && teacher != null)
            {
                course.SetTeacher(teacher);
                teacher.AddCourse(course);
                Console.WriteLine("Преподаватель назначен.");
            }
            else
            {
                Console.WriteLine("Курс или преподаватель не найден.");
            }
        }

        public void AddStudentToCourse(string courseName, Student student)
        {
            Course course = FindCourse(courseName);
            if (course != null)
            {
                course.AddStudent(student);
                Console.WriteLine("Студент добавлен.");
            }
            else
            {
                Console.WriteLine("Курс не найден.");
            }
        }

        public void PrintCoursesByTeacher(string teacherName)
        {
            Teacher teacher = FindTeacher(teacherName);
            if (teacher != null)
            {
                List<Course> teacherCourses = teacher.GetCourses();
                Console.WriteLine("Курсы преподавателя:");
                for (int i = 0; i < teacherCourses.Count; i++)
                {
                    Console.WriteLine(teacherCourses[i].Name);
                }
            }
            else
            {
                Console.WriteLine("Преподаватель не найден.");
            }
        }

        public void PrintAllCourses()
        {
            Console.WriteLine("Список всех курсов:");
            for (int i = 0; i < courses.Count; i++)
            {
                courses[i].PrintInfo();
            }
        }

        private Course FindCourse(string name)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Name == name)
                    return courses[i];
            }
            return null;
        }

        private Teacher FindTeacher(string name)
        {
            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachers[i].Name == name)
                    return teachers[i];
            }
            return null;
        }
    }
}