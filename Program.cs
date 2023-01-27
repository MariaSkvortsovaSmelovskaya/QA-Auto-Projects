// See https://aka.ms/new-console-template for more information

namespace LegalStructure;

public class Program
{
    static void Main(string[] args)
    {
        {
            var employees0 = new Rectorat(new Person("Yan", "Petrov"), 458, "Rector");

            var employees1 = new
                Teacher (new Person ("Gleb", "Glinka"), 123, "Criminal law teacher",
                new Course ("Criminal law", "Basics of criminal law,criminal code part one"));

            var employees2 = new 
                Teacher (new Person ("Stefania", "Stanko"), 341, "English teacher",
                new Course ("English readings", "Classic program from UK school"));

            var employees3 = new
                SupportStaff (new Person("Alex", "Orech"), 432, "Security", "Checking students cards");

            var employees4 = new 
                SupportStaff (new Person("Peter", "Sidorov"), 412, "Driver", "Books delivery to the libraries");

            var employees5 = new 
                SupportStaff (new Person("Klara", "Tamara"), 567, "Cleaner", "Cleaning only first and four floors");



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
            var room8 = new Room("Pantry", 102);


            building1.Rooms = new List<Room>() { room1, room2 };
           
            building2.Rooms = new List<Room>() { room3, room4 };
            
            building3.Rooms = new List<Room>() { room5, room6 };
            
            building4.Rooms = new List<Room>() { room7, room8 };

           
            var employees = new List<Employee>();


            var universityMinsk = new University(employees, new List<Building> { building1, building2, building3, building4 }, employees0, "220065, Belarus, Minsk, ul.Lenina 6");
            universityMinsk.AddEmployee(employees1);
            universityMinsk.AddEmployee(employees2);
            universityMinsk.AddEmployee(employees3);
            universityMinsk.AddEmployee(employees4);
            universityMinsk.AddEmployee(employees5);

            foreach (var item in universityMinsk.Employees)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}




