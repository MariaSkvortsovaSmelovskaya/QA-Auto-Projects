

namespace Sort
{
    public class Teacher : Employee
    {
        public Course Course { get; set; }

        public List<Course> Courses { get; set; }


        public Teacher(Person personEmployee, int taxId, string universityEmployeePosition, Course course) :
            base(personEmployee?.FirstName, personEmployee?.LastName, taxId, universityEmployeePosition)
        {
            Course = course;
            Courses = new List<Course>();
        }

        public Teacher(string firstName, string lastName, int taxId, string universityEmployeePosition, Course course) :
            base(firstName, lastName, taxId, universityEmployeePosition)
        {
            Course = course;
        }


        public override string GetOfficialDuties()
        {
            return $"{Course.CourseName} {Course.CourseDescription}";
        }

        public override string GetPositionName()
        {
            return "Teacher";
        }

        
    }
}
        
     




