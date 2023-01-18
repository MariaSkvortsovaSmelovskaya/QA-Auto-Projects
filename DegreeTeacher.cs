
namespace UniversityEmployee
{
   public class DegreeTeacher: Teacher
   {
        public string ScienceDegree { get; set; }
        
        public string Rank { get; set; }

        public DegreeTeacher(Person personEmployee, int taxId, Course course, string scienceDegree, string rank): 
                base(personEmployee, taxId, course)
        {
            ScienceDegree = scienceDegree;
            Rank = rank;
        }
        public override string GetOfficialDuties()
        {
            return $"{ Course.CourseName} { Course.CourseDescription} { ScienceDegree}";
        }

        public override string GetPositionName() 
        {
            return "DegreeTeacher";
        }
   }
}
