using Xunit;
using UniversitySystem;

namespace UniversitySystem.Tests
{
    public class UniversityTests
    {
        [Fact]
        public void AddCourse_ShouldIncreaseCourseCount()
        {
            University university = new University();
            university.AddCourse(new OnlineCourse("Математика", "zoom.com"));

            university.AddStudentToCourse("Математика", new Student("Иван"));
        }

        [Fact]
        public void AssignTeacherToCourse_ShouldAddCourseToTeacher()
        {
            University university = new University();
            Teacher teacher = new Teacher("Петров");

            university.AddTeacher(teacher);
            university.AddCourse(new OfflineCourse("Физика", "101"));
            university.AssignTeacherToCourse("Физика", "Петров");

            Assert.Single(teacher.GetCourses());
        }

        [Fact]
        public void AddStudentToCourse_ShouldAddStudent()
        {
            OnlineCourse course = new OnlineCourse("Информатика", "teams.com");
            Student student = new Student("Анна");

            course.AddStudent(student);

            Assert.Single(course.GetStudents());
        }
    }
}