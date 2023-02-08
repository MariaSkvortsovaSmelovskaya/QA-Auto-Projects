

using System.Diagnostics.Metrics;

namespace Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
                var employees0 = new
                    Rectorat(new Person("Yan", "Petrov"), 458, "Rector");

                var employees1 = new
                    Teacher(new Person("Gleb", "Glinka"), 123, "Criminal law teacher",
                    new Course("Criminal law", "Basics of criminal law,criminal code part one"));

                var employees2 = new
                    Teacher(new Person("Asya", "Sledneva"), 321, "Criminal law teacher",
                    new Course("Criminal law", "Basics of criminal law,criminal code part one"));

                var employees3 = new
                    Teacher(new Person("Stefania", "Stanko"), 345, "English teacher",
                    new Course("English readings", "Classic program from UK school"));

                var employees4 = new
                    Teacher(new Person("Aleksandra", "Shatz"), 341, "English teacher",
                    new Course("English readings", "Classic program from UK school"));

                var employees5 = new
                    Teacher(new Person("Kirill", "Petrov"), 361, "Civil law teacher",
                    new Course("Civil law", "Basics of civil law,civil code part one"));

                var employees6 = new
                    SupportStaff(new Person("Alex", "Orech"), 432, "Security", "Checking students cards");

                var employees7 = new
                    SupportStaff(new Person("Peter", "Sidorov"), 412, "Driver", "Books delivery to the libraries");

                var employees8 = new
                    SupportStaff(new Person("Klara", "Tamara"), 567, "Cleaner", "Cleaning only first and four floors");



                var building1 = new Building("Sevastopolskaya", 32);
                var building2 = new Building("Pushkina", 145);
                var building3 = new Building("Ivolgina", 44);
                var building4 = new Building("Kirova", 25);

                var room1 = new Room("Lecture class", 112);
                var room2 = new Room("Laboratoty", 005);
                var room3 = new Room("Pantry", 001);
                var room4 = new Room("Seminar class", 402);
                var room5 = new Room("Seminar class", 312);
                var room6 = new Room("Lecture class", 605);
                var room7 = new Room("Laboratoty", 333);
                var room8 = new Room("Pantry", 112);

                building1.Rooms = new List<Room>() { room1 };

                building2.Rooms = new List<Room>() { room3, room4, room5 };

                building3.Rooms = new List<Room>() { room6 };

                building4.Rooms = new List<Room>() { room7, room8, room2 };


                var courses1 = new Course("Criminal law", "Basics of criminal law,criminal code part one");
                var courses2 = new Course("Criminal law", "Basics of criminal law,criminal code part one");
                var courses3 = new Course("English readings", "Classic program from UK school");
                var courses4 = new Course("English readings", "Classic program from UK school");
                var courses5 = new Course("Civil law", "Basics of civil law,civil code part one");

                var courses = new List<Course>() { courses1, courses2, courses3, courses4, courses5 };
                var buildings = new List<Building>() { building1, building2, building3, building4 };
                var employees = new List<Employee>() { employees0, employees1, employees2, employees3, employees4, employees5, employees6, employees7, employees8 };
                var rooms = new List<Room>() { room1, room2, room3, room4, room5, room6, room7, room8 };

                var universityMinsk = new University(employees, new List<Building> { building1, building2, building3, building4 }, employees0, "220065, Belarus, Minsk, ul.Lenina 6");
                universityMinsk.AddEmployee(employees0);
                universityMinsk.AddEmployee(employees1);
                universityMinsk.AddEmployee(employees2);
                universityMinsk.AddEmployee(employees3);
                universityMinsk.AddEmployee(employees4);
                universityMinsk.AddEmployee(employees5);
                universityMinsk.AddEmployee(employees6);
                universityMinsk.AddEmployee(employees7);
                universityMinsk.AddEmployee(employees8);

               

                //1

                Console.WriteLine("Add first letter:");
                var firstLetter = Console.ReadLine();
                var sortEmployees = employees.Where(x => x.LastName.StartsWith(firstLetter)).OrderBy(x => x.TaxId).Select(x => $"{x.LastName}: {x.TaxId}").ToList();

                foreach (var employee in sortEmployees)
                { 
                    Console.WriteLine(employee);
                }

                
                //2

                Console.WriteLine("Add course:");
                var courseName = Console.ReadLine();
                var sortTeachers = employees.Where(x => x is Teacher && (x as Teacher).Course.CourseName.Contains(courseName)).Select(x => $"{x.FirstName} {x.LastName}").ToList();

                foreach (var employee1 in sortTeachers) 
                {
                        Console.WriteLine(employee1);  
                }
                

                //3
                Console.WriteLine(string.Join(",\n ", employees.Select(x => $"{x.TaxId} {x.GetOfficialDuties()}")));


                //4
                var sortRooms = buildings.Where(x => x.Rooms.Any(y => y.Placement == 112)).ToList();
                   
                foreach (var building in sortRooms)
                {
                    Console.WriteLine( $"{building.Street} {building.Block}");
                }

                //5
                var sortBuildings = buildings.MaxBy(x => x.Rooms.Count());
                Console.WriteLine(sortBuildings.Street);


                //6
                var sortPopularLastName = employees.GroupBy(x => x.LastName).MaxBy(y => y.Count());
                Console.WriteLine($"{sortPopularLastName.Key} {sortPopularLastName.Count()}");


        }
    }
}
               



