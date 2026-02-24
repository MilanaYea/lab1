using System.Collections.Generic;

namespace UniversitySystem
{
    public class Teacher
    {
        public string Name { get; private set; }
        private List<Course> courses = new List<Course>();

        public Teacher(string name)
        {
            Name = name;
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public List<Course> GetCourses()
        {
            return courses;
        }
    }
}