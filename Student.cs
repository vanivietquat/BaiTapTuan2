using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan2
{
    internal class Student
    {
        private string studentID;
        private string fullName;
        private int age;

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Age { get => age; set => age = value; }

        public Student() { }

        public Student(string studentID, string fullName, int age)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.age = age;
        }
        public void Input()
        {
            Console.Write("Nhập MSSV:");
            StudentID = Console.ReadLine();
            Console.Write("Nhập Họ tên Sinh viên:");
            FullName = Console.ReadLine();
            Console.Write("Nhập Tuổi:");
            Age = int.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine($"MSSV:{this.studentID} Họ Tên:{this.FullName} Tuổi:{this.Age}");
        }

    }
}
