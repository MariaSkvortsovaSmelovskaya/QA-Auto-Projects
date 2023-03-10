
namespace Exeptions
{
    public class Employee : Person, IComparable, IComparable<Employee>
    {
        private int _taxId;

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

                if (value < 0)
                {
                    throw new ArgumentException("Unaccepted number");
                }

                _taxId = value;

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

        public int CompareTo(Employee emp)
        {
            if (emp == null)
            {
                return 1;
            }

            else
            {
                return -LengthCheck() + emp.LengthCheck();
            }
        }

        public int CompareTo(object? obj)
        {
            return LengthCheck().CompareTo((obj as Employee)?.LengthCheck());
        }


    }
}

    

