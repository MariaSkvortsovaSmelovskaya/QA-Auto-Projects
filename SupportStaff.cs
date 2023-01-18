
namespace UniversityEmployee
{
    internal class SupportStaff: Employee
    {
        public string StaffName { get; set; }
       
        public string StaffDuties { get; set; }

        public SupportStaff(Person personEmployee, int taxId, string staffName, string staffDuties): base(personEmployee, taxId)
        {
            StaffName = staffName;
            StaffDuties = staffDuties;
        }
        public override string GetOfficialDuties()
        {
              return $"{StaffName} {StaffDuties}";
        }

        public override string GetPositionName()
        {
            return "SupportStaff";
        }
    }
    
}
