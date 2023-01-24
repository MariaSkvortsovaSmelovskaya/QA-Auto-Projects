// See https://aka.ms/new-console-template for more information

namespace LegalStructure;

public class Program
{
    static void Main(string[] args)
    {
        {
            var employees0 = new
                Rectorat(new Person("Yan", "Petrov"), 458, "Rector");

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



            Building building1 = new ("Sevastopolskaya", 32);
            Building building2 = new ("Pushkina", 145);
            Building building3 = new ("Ivolgina", 44);
            Building building4 = new ("Kirova", 25);

            Room room1 = new Room("Lecture class", 112);
            Room room2 = new Room("Laboratoty", 005);
            Room room3 = new Room("Pantry", 001);
            Room room4 = new Room("Seminar class", 402);
            Room room5 = new Room("Seminar class", 312);
            Room room6 = new Room("Lecture class", 605);
            Room room7 = new Room("Laboratoty", 333);
            Room room8 = new Room("Pantry", 102);

            building1.Rooms = new List<Room>();
            building1.Rooms.Add(room1);
            building1.Rooms.Add(room2);


            building2.Rooms = new List<Room>();
            building2.Rooms.Add(room3);
            building2.Rooms.Add(room4);

            building3.Rooms = new List<Room>();
            building3.Rooms.Add(room5);
            building3.Rooms.Add(room6);

            building4.Rooms = new List<Room>();
            building4.Rooms.Add(room7);
            building4.Rooms.Add(room8);

            var employees = new List<Employee>();

            var universityMinsk = new University(employees, new List<Building> { building1, building2, building3, building4 }, employees0, "220065, Belarus, Minsk, ul.Lenina 6");
            universityMinsk.AddEmployee(employees1);
            universityMinsk.AddEmployee(employees2);
            universityMinsk.AddEmployee(employees3);
            universityMinsk.AddEmployee(employees4);
            universityMinsk.AddEmployee(employees5);
        }
    }
}




