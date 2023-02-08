
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Sort
{
    public class Employee : Person
    {
        private int _taxId;
        private const int Max_Tax_Rate = 1000;

        public List<Employee> employees { get; set; }
        public string UniversityEmployeePosition { get; set; }

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


        public Employee(string firstName, string lastName, int taxId, string universityEmployeePosition) :
            base(firstName, lastName)
        {
            TaxId = taxId;
            UniversityEmployeePosition = universityEmployeePosition;
        }

        public virtual string GetOfficialDuties()
        {
            return "Visit daily meetings before starting of working day ";
        }

        public virtual string GetPositionName()
        {
            return "Employee";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Employee emp)
            {
                return TaxId == emp.TaxId;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return TaxId.GetHashCode();
        }

    }
}

        

  
