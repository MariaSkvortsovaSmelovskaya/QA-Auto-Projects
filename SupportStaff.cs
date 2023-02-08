

namespace Sort
{
    public class SupportStaff : Employee
    {

        public string StaffDuties { get; set; }
        public SupportStaff(Person personEmployee, int taxId, string universityEmployeePosition, string staffDuties) :
            base(personEmployee?.FirstName, personEmployee?.LastName, taxId, universityEmployeePosition)
        {
            StaffDuties = staffDuties;
        }
        public override string GetOfficialDuties()
        {
            return "StaffDuties";
        }

        public override string GetPositionName()
        {
            return "SupportStaff";
        }

    }
}
