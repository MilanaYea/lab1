using System;
using System.Collections.Generic;

namespace UniversitySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nСистема управления университетом");
                Console.WriteLine("1. Добавить преподавателя");
                Console.WriteLine("2. Добавить курс");
                Console.WriteLine("3. Удалить курс");
                Console.WriteLine("4. Назначить преподавателя на курс");
                Console.WriteLine("5. Добавить студента на курс");
                Console.WriteLine("6. Показать курсы преподавателя");
                Console.WriteLine("7. Показать все курсы");
                Console.WriteLine("0. Выход");

                Console.Write("Выберите пункт меню: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите имя преподавателя: ");
                        string teacherName = Console.ReadLine();
                        university.AddTeacher(new Teacher(teacherName));
                        break;

                    case "2":
                        Console.Write("Введите название курса: ");
                        string courseName = Console.ReadLine();

                        Console.WriteLine("Тип курса: 1 - Онлайн, 2 - Офлайн");
                        string type = Console.ReadLine();

                        if (type == "1")
                        {
                            Console.Write("Введите ссылку на платформу: ");
                            string link = Console.ReadLine();
                            university.AddCourse(new OnlineCourse(courseName, link));
                        }
                        else if (type == "2")
                        {
                            Console.Write("Введите аудиторию: ");
                            string room = Console.ReadLine();
                            university.AddCourse(new OfflineCourse(courseName, room));
                        }
                        break;

                    case "3":
                        Console.Write("Введите название курса для удаления: ");
                        university.RemoveCourse(Console.ReadLine());
                        break;

                    case "4":
                        Console.Write("Название курса: ");
                        string cName = Console.ReadLine();
                        Console.Write("Имя преподавателя: ");
                        string tName = Console.ReadLine();
                        university.AssignTeacherToCourse(cName, tName);
                        break;

                    case "5":
                        Console.Write("Название курса: ");
                        string courseForStudent = Console.ReadLine();
                        Console.Write("Имя студента: ");
                        string studentName = Console.ReadLine();
                        university.AddStudentToCourse(courseForStudent, new Student(studentName));
                        break;

                    case "6":
                        Console.Write("Имя преподавателя: ");
                        string teacherCourses = Console.ReadLine();
                        university.PrintCoursesByTeacher(teacherCourses);
                        break;

                    case "7":
                        university.PrintAllCourses();
                        break;

                    case "0":
                        exit = true;
                        break;
                }
            }
        }
    }
}