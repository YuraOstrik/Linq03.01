using System;
using System.Collections.Generic;
using System.Linq;

namespace Where._03._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firm> firms = new List<Firm>
            {
                new Firm
                {
                    Name = "FoodHub",
                    FoundationDate = new DateTime(2020, 5, 1),
                    BusinessProfile = "Marketing",
                    DirectorFullName = "John White",
                    EmployeesCount = 150,
                    Address = "London",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Alice Johnson", Position = "Marketing Specialist", Phone = "123-456-789", Email = "alice.johnson@foodhub.com", Salary = 4000 },
                        new Employee { FullName = "Lionel Brown", Position = "Manager", Phone = "230-654-321", Email = "lionel.brown@foodhub.com", Salary = 5000 }
                    }
                },
                new Firm
                {
                    Name = "TechWorld",
                    FoundationDate = new DateTime(2015, 3, 15),
                    BusinessProfile = "IT",
                    DirectorFullName = "Emily Black",
                    EmployeesCount = 250,
                    Address = "New York",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Charles Green", Position = "Software Developer", Phone = "456-789-123", Email = "charles.green@techworld.com", Salary = 7000 },
                        new Employee { FullName = "Diana Blue", Position = "Manager", Phone = "234-321-987", Email = "diana.blue@techworld.com", Salary = 6000 }
                    }
                }
            };

            Console.WriteLine("Сотрудники фирмы Food: ");
            firms.Where(f => f.Name.Contains("Food")).ToList().ForEach(PrintFirmWithEmployees);
            Console.WriteLine("\nСотрудники фирмы FoodHub с зарплатой больше 4500:");
            firms.Where(f => f.Name.Contains("Food"))
                 .ToList()
                 .ForEach(f => f.Employees.Where(e => e.Salary > 4500).ToList().ForEach(PrintEmployee));

            
            Console.WriteLine("\nСотрудники всех фирм с должностью 'Manager':");
            firms.SelectMany(f => f.Employees)
                 .Where(e => e.Position == "Manager")
                 .ToList()
                 .ForEach(PrintEmployee);

            
            Console.WriteLine("\nСотрудники с телефоном, начинающимся на '23':");
            firms.SelectMany(f => f.Employees)
                 .Where(e => e.Phone.StartsWith("23"))
                 .ToList()
                 .ForEach(PrintEmployee);

            
            Console.WriteLine("\nСотрудники с Email, начинающимся на 'di':");
            firms.SelectMany(f => f.Employees)
                 .Where(e => e.Email.StartsWith("di", StringComparison.OrdinalIgnoreCase))
                 .ToList()
                 .ForEach(PrintEmployee);

            
            Console.WriteLine("\nСотрудники с именем 'Lionel':");
            firms.SelectMany(f => f.Employees)
                 .Where(e => e.FullName.Split(' ').First() == "Lionel")
                 .ToList()
                 .ForEach(PrintEmployee);
            //List<Firm> firms = new List<Firm>
            //{
            //    new Firm { Name = "FoodHub", FoundationDate = new DateTime(2020, 5, 1), BusinessProfile = "Marketing", DirectorFullName = "John White", EmployeesCount = 150, Address = "London" },
            //    new Firm { Name = "TechWorld", FoundationDate = new DateTime(2015, 3, 15), BusinessProfile = "IT", DirectorFullName = "Emily Black", EmployeesCount = 250, Address = "New York" },
            //    new Firm { Name = "FoodTech", FoundationDate = new DateTime(2018, 8, 10), BusinessProfile = "IT", DirectorFullName = "Michael Brown", EmployeesCount = 90, Address = "London" },
            //    new Firm { Name = "WhiteBlack Solutions", FoundationDate = new DateTime(2019, 11, 5), BusinessProfile = "Marketing", DirectorFullName = "Robert Black", EmployeesCount = 120, Address = "Paris" }
            //};

            //Console.WriteLine("\nВсе фирмы: ");
            //firms.ForEach(f => PrintFirms(f));

            //var food = firms.Where(f => f.Name.Contains("Food"));
            //Console.WriteLine("\nФирмы с названием, содержащим 'Food': ");
            //food.ToList().ForEach(f => PrintFirms(f));

            //var marketing = firms.Where(f => f.BusinessProfile == "Marketing");
            //Console.WriteLine("\nФирмы с профилем 'Marketing': ");
            //marketing.ToList().ForEach(f => PrintFirms(f));

            //var marketingOrIT = firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT");
            //Console.WriteLine("\nФирмы с профилем 'Marketing' или 'IT': ");
            //marketingOrIT.ToList().ForEach(f => PrintFirms(f));

            //var moreThan100 = firms.Where(f => f.EmployeesCount > 100);
            //Console.WriteLine("\nФирмы с количеством сотрудников больше 100: ");
            //moreThan100.ToList().ForEach(f => PrintFirms(f));

            //var range100To300 = firms.Where(f => f.EmployeesCount >= 100 && f.EmployeesCount <= 300);
            //Console.WriteLine("\nФирмы с количеством сотрудников от 100 до 300: ");
            //range100To300.ToList().ForEach(f => PrintFirms(f));

            //var londonFirms = firms.Where(f => f.Address == "London");
            //Console.WriteLine("\nФирмы в Лондоне: ");
            //londonFirms.ToList().ForEach(f => PrintFirms(f));

            //var whiteDirectors = firms.Where(f => f.DirectorFullName.Split(' ').Last() == "White");
            //Console.WriteLine("\nФирмы с директором White: ");
            //whiteDirectors.ToList().ForEach(f => PrintFirms(f));

            //var oldFirms = firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays > 2 * 365);
            //Console.WriteLine("\nФирмы, основанные больше двух лет назад: ");
            //oldFirms.ToList().ForEach(f => PrintFirms(f));

            //var days123 = firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays == 123);
            //Console.WriteLine("\nФирмы, которым 123 дня: ");
            //days123.ToList().ForEach(f => PrintFirms(f));

            //var blackDirectorWhiteName = firms.Where(f => f.DirectorFullName.Split(' ').Last() == "Black" && f.Name.Contains("White"));
            //Console.WriteLine("\nФирмы с директором Black и названием, содержащим 'White': ");
            //blackDirectorWhiteName.ToList().ForEach(f => PrintFirms(f));

            //2 задание
            //Console.WriteLine("\nВсе фирмы:");
            //firms.ForEach(PrintFirm);

            //Console.WriteLine("\nФирмы с названием, содержащим 'Food':");
            //firms.Where(f => f.Name.Contains("Food")).ToList().ForEach(PrintFirm);

            //Console.WriteLine("\nФирмы с профилем 'Marketing':");
            //firms.Where(f => f.BusinessProfile == "Marketing").ToList().ForEach(PrintFirm);

            //Console.WriteLine("\nФирмы с профилем 'Marketing' или 'IT':");
            //firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT").ToList().ForEach(PrintFirm);

            //Console.WriteLine("\nФирмы с количеством сотрудников больше 100:");
            //firms.Where(f => f.EmployeesCount > 100).ToList().ForEach(PrintFirm);

            //Console.WriteLine("\nФирмы с количеством сотрудников от 100 до 300:");
            //firms.Where(f => f.EmployeesCount >= 100 && f.EmployeesCount <= 300).ToList().ForEach(PrintFirm);

            //Console.WriteLine("\nФирмы в Лондоне:");
            //firms.Where(f => f.Address == "London").ToList().ForEach(PrintFirm);

            //Console.WriteLine("\nФирмы с директором White:");
            //firms.Where(f => f.DirectorFullName.Split(' ').Last() == "White").ToList().ForEach(PrintFirm);

            //Console.WriteLine("\nФирмы, основанные больше двух лет назад:");
            //firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays > 2 * 365).ToList().ForEach(PrintFirm);

            //Console.WriteLine("\nФирмы, которым 123 дня:");
            //firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays == 123).ToList().ForEach(PrintFirm);


            //Console.WriteLine("\nФирмы с директором Black и названием, содержащим 'White':");
            //firms.Where(f => f.DirectorFullName.Split(' ').Last() == "Black" && f.Name.Contains("White")).ToList().ForEach(PrintFirm);
        }

        class Firm
        {
            public string Name { get; set; }
            public DateTime FoundationDate { get; set; }
            public string BusinessProfile { get; set; }
            public string DirectorFullName { get; set; }
            public int EmployeesCount { get; set; }
            public string Address { get; set; }
            public List<Employee> Employees { get; set; }
        }
        class Employee
        {
            public string FullName { get; set; }
            public string Position { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public decimal Salary { get; set; }
        }

        static void PrintFirms(Firm firm)
        {
            Console.WriteLine($"Название: {firm.Name}, Дата основания: {firm.FoundationDate.ToShortDateString()}, Профиль: {firm.BusinessProfile}, Директор: {firm.DirectorFullName}, Сотрудников: {firm.EmployeesCount}, Адрес: {firm.Address}");
        }
        static void PrintFirmWithEmployees(Firm firm)
        {
            Console.WriteLine($"Название: {firm.Name}, Дата основания: {firm.FoundationDate.ToShortDateString()}, Профиль: {firm.BusinessProfile}, Директор: {firm.DirectorFullName}, Сотрудников: {firm.EmployeesCount}, Адрес: {firm.Address}");
            Console.WriteLine("Сотрудники:");
            firm.Employees.ForEach(e => Console.WriteLine($"  ФИО: {e.FullName}, Должность: {e.Position}, Телефон: {e.Phone}, Email: {e.Email}, Зарплата: {e.Salary}"));
        }
        static void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"\tФИО: {employee.FullName}, Должность: {employee.Position}, Телефон: {employee.Phone}, Email: {employee.Email}, Зарплата: {employee.Salary}");
        }
    }
}
