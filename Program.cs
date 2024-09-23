using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan2
{
    internal class Program
    {
        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("=== Nhập thông tin sinh viên ===");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Thêm sinh viên thành công!");
        }

        static void DisplayStudentList(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sách chi tiết thông tin sinh viên ===");
            foreach (Student student in studentList)
            {
                student.Show();
            }
        }


        static void DisplayStudentsByAgeRange(List<Student> studentList, int minAge, int maxAge)
        {
            Console.WriteLine($"=== Danh sách sinh viên có tuổi từ {minAge} đến {maxAge}===");
            var students = studentList.Where(s => s.Age >= minAge && s.Age <= maxAge);
            foreach (var student in students)
            {
                student.Show();
            }
        }
        static void DisplayStudentsStartingWithA(List<Student> studentList)
        {
            Console.WriteLine("===Danh sách tên học sinh bắt đầu bằng chữ A===");
            var students = studentList.Where(s => s.FullName.StartsWith ("A", StringComparison.OrdinalIgnoreCase));
            foreach(var student  in students)
            {
                student.Show();
            }
        }

        static void FindOldestStudent(List<Student> studentList)
        {
            Console.WriteLine("===Học sinh có số tuổi lớn nhất==");
            int maxAge = studentList.Max(s => s.Age);
            var oldest = studentList.Where(s=>s.Age == maxAge);
            foreach(var student in oldest)
            {
                student.Show();
            }
        }
        static void CalculateTotalAge(List<Student> studentList)
        {
            int totalAge = studentList.Sum(s => s.Age);
            Console.WriteLine($"Tổng tuổi của tất cả sinh viên: {totalAge}");
        }

        static void SortStudentsByAge(List<Student> studentList)
        {
            var sortedStudents = studentList.OrderBy(s => s.Age).ToList();
            Console.WriteLine("=== Danh sách sinh viên sắp xếp theo tuổi tăng dần ===");
            foreach (var student in sortedStudents)
            {
                student.Show();
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;


            List<Student> studentList = new List<Student>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Hiển thị sinh viên từ 15 đến 18 tuổi");
                Console.WriteLine("4. Hiển thị sinh viên có tên bắt đầu bằng chữ A");
                Console.WriteLine("5. Tính tổng tuổi của tất cả sinh viên");
                Console.WriteLine("6. Tìm sinh viên có tuổi lớn nhất");
                Console.WriteLine("7. Sắp xếp sinh viên theo tuổi tăng dần");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chuc nang (0-7): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);

                        break;
                    case "2":
                        DisplayStudentList(studentList);

                        break;
                    case "3":
                        DisplayStudentsByAgeRange(studentList, 15, 18);
                        break;
                    case "4":
                        DisplayStudentsStartingWithA(studentList);
                        break;
                    case "5":
                        CalculateTotalAge(studentList);
                        break;
                    case "6":
                        FindOldestStudent(studentList);
                        break;
                    case "7":
                        SortStudentsByAge(studentList);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại.");


                        break;
                }
                Console.WriteLine();
            }
        }

    }
}
