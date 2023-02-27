

namespace Exeptions
{
    public class Rectorat: Employee
    {
        public Rectorat(Person personEmployee, int taxId, string universityEmployeePosition) :
               base(personEmployee?.FirstName, personEmployee?.LastName, taxId, universityEmployeePosition)
        {
            UniversityEmployeePosition = universityEmployeePosition;
        }

    public override string GetOfficialDuties()
    {
        return "Manage the University";
    }
        
    }

}

