using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Tạo danh sách học sinh
                List<student> students = new List<student>
            {
                new student { Id = 1, Name = "Hai", Age = 17 },
                new student { Id = 2, Name = "Linh", Age = 16 },
                new student { Id = 3, Name = "Loc", Age = 18 },
                new student { Id = 4, Name = "Thanh", Age = 14 },
                new student { Id = 5, Name = "Hoa", Age = 19 }
            };

                // a. In toàn bộ danh sách học sinh
                Console.WriteLine("a. Danh sach toan bo hoc sinh:");
                foreach (var student in students)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }

                // b. Tìm và in danh sách học sinh có tuổi từ 15 đến 18
                Console.WriteLine("\nb. Hoc sinh co tuoi tu 15 đen 18:");
                var ageRangeStudents = students.Where(s => s.Age >= 15 && s.Age <= 18);
                foreach (var student in ageRangeStudents)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }

                // c. Tìm và in học sinh có tên bắt đầu bằng chữ "A"
                Console.WriteLine("\nc. Hoc sinh co ten bat đau bang chu 'A':");
                var studentsWithA = students.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
                foreach (var student in studentsWithA)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }

                // d. Tính tổng tuổi của tất cả học sinh
                int totalAge = students.Sum(s => s.Age);
                Console.WriteLine($"\nd. Tong tuoi cua tat ca hoc sinh: {totalAge}");

                // e. Tìm và in học sinh có tuổi lớn nhất
                var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
                if (oldestStudent != null)
                {
                    Console.WriteLine($"\ne. Hoc sinh co tuoi lon nhat: Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
                }

                // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra
                Console.WriteLine("\nf. Danh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
                var sortedStudents = students.OrderBy(s => s.Age);
                foreach (var student in sortedStudents)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }
            }
        }
    }
}
