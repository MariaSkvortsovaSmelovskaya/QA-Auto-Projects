

namespace UniversityEmployee
{
    public class Employee
    {
        private int _taxId;
        private const int Max_Tax_Rate = 18;
        
        public Person PersonEmployee { get; set; }

        public int TaxId
        {
            get
            {
                return _taxId;
            }
            set
            {
                if (value > 0 && value < Max_Tax_Rate)
                {
                    _taxId = value;
                }

            }
        }

        public Employee(Person personEmployee, int taxId)
        {
            PersonEmployee = personEmployee;
            TaxId = taxId;
        }

        public virtual string GetOfficialDuties()
        {
            return "Visit daily meetings before starting of working day ";
        }

        public virtual string GetPositionName()
        {
            return "Employee";
        }
    }   


}
