using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyHocSinh
{
    //      lop Student
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //sach hoc sinh
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen binh An", Age = 16 },
                new Student { Id = 2, Name = "liem Van Bao", Age = 17 },
                new Student { Id = 3, Name = "Nguyen Quynh Anh", Age = 18 },
                new Student { Id = 4, Name = "Pham Nhat Vuong", Age = 15 },
                new Student { Id = 5, Name = "Nguyen Thi Ngoc Dung", Age = 19 }
            };

            // cau a:
            Console.WriteLine("a. Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            //Caub
            Console.WriteLine("\nb. Hoc sinh co tuoi tu 15 den 18:");
            var filteredAge = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in filteredAge)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            //cau c 
            Console.WriteLine("\nc. Hoc sinh co ten bat dau bang chu 'A':");
            var startsWithA = students.Where(s =>
            {
                var words = s.Name.Split(' ');
                var lastWord = words[words.Length - 1];
                return lastWord.StartsWith("A", StringComparison.OrdinalIgnoreCase);
            });
            foreach (var student in startsWithA)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            //cau d 
            Console.WriteLine("\nd. Tong tuoi cua tat ca hoc sinh:");
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tong tuoi: {totalAge}");
            //cau e 
            Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
            int maxAge = students.Max(s => s.Age);
            var oldestStudents = students.Where(s => s.Age == maxAge);
            foreach (var student in oldestStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            //cau f 
            Console.WriteLine("\nf. Danh sach hoc sinh sap xep theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
