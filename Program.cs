// See https://aka.ms/new-console-template for more information
namespace UniversityEmployee
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var employee1 = new Teacher(
                new Person("Gleb", "Glinka"), 123,
                new Course("Criminal law", "Basics of criminal law,criminal code part one"));

            var employee2 = new DegreeTeacher(
                new Person("Anna", "Shatz"), 234,
                new Course("Civil law", "Basics of civil law,civil code part two"),
                "Proffessor",
                "Docent");

            var employee3 = new Teacher(
                new Person("Stefania", "Stanko"), 341,
                new Course("English readings", "Classic program from UK school"));

            var employee4 = new SupportStaff(
                new Person("Peter", "Sidorov"), 412,
                "Driver", "Books delivery to the libraries");

            var employee5 = new SupportStaff(
                new Person("Alex", "Orech"), 432,
                "Security", "Checking students cards");

            var employee6 = new SupportStaff(
                    new Person("Klara", "Tamara"), 567,
                    "Cleaner", "Cleaning only first and four floors");

            Employee[] employees = new Employee[]
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetOfficialDuties());
            }


            foreach (var employee in employees)
            {
                if (employee is Teacher)
                {
                    Console.WriteLine(employee.GetOfficialDuties());
                }
            }
        }

    }
}

