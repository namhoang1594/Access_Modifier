using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "M.Cong", "Ha noi", 30);
            Student student2 = new Student();
            student2.SetID(2);
            student2.SetName("Ph. Quang Khanh");
            student2.SetAddress("Lang Son");
            student2.SetAge(25);
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
        }
    }
}
