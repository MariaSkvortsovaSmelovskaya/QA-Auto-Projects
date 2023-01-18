
namespace UniversityEmployee
{
    public class Teacher: Employee
    {
        public Course Course { get; set; }
        public Teacher(Person personEmployee, int taxId, Course course): base(personEmployee, taxId)
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

