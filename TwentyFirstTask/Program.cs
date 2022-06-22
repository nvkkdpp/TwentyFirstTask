using System;

namespace TwentyFirstTask
{
    public class Program
    {
        static void Main(string[] strings)
        {
            Student student = new Student();
            student.Init("Huesos Huesosov", 1234);
            Console.WriteLine("Внесение в список" + "Huesos Huesosov" + "Курса Huyology 101");
            student.Enroll("Huyology 101");
            Console.WriteLine("Информация о студенте:");
            student.DisplayCourse();
            Console.WriteLine("Нажмите на свой анус, но лучше завершить программу посредством нажатия <enter> . . .");
            Console.Read();
        }
    }
    public class Student
    {
        public string _name;
        public int _id;
        CourseInstance _courseInstance;
        public void Init(string name, int id)
        {
            this._name = name;
            this._id = id;
            _courseInstance = null;
        }
        public void Enroll(string sCourseID)
        {
            _courseInstance = new CourseInstance();
            _courseInstance.Init(this, sCourseID);
        }
        public void DisplayCourse()
        {
            Console.WriteLine(_name);
            _courseInstance.Display();
        }
    }
    public class CourseInstance
    {
        public Student _student;
        public string _courseID;

        public void Init(Student student, string CourseID)
        {
            this._student = student;
            this._courseID = CourseID;
        }
        public void Display()
        {
            Console.WriteLine(_courseID);
        }
    }
}