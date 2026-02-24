using System;

namespace UniversitySystem
{
    public class OfflineCourse : Course
    {
        public string Room { get; private set; }

        public OfflineCourse(string name, string room) : base(name)
        {
            Room = room;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Офлайн курс: " + Name + ", Аудитория: " + Room);
        }
    }
}