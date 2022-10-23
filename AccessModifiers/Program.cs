using System;

namespace LessonManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Teacher
    {
        protected int Id { get; set; }
        public void Save()
        {

        }
        public void Delete()
        {

        }
    }

    class Student:Teacher
    {
        public void Save2()
        {
         

        }
    }

    public class Lesson
    {
        public string Name { get; set; }
    }
}
