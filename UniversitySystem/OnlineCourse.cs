using System;

namespace UniversitySystem
{
    public class OnlineCourse : Course
    {
        public string PlatformLink { get; private set; }

        public OnlineCourse(string name, string link) : base(name)
        {
            PlatformLink = link;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Онлайн курс: " + Name);
            Console.WriteLine("Ссылка на онлайн-платформу: " + PlatformLink);
        }
    }
}