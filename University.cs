

namespace LegalStructure
{
    public class University
    {

        public List<Building> Buildings { get; set; }
        public Rectorat Rector { get; set; }
        public string LegalAddress { get; set; }
        public List<Employee> Employees { get; set; }
        public University(List<Employee> employees, List<Building> buildings, Rectorat rector, string legalAddress)
        {
            Employees = employees;
            Buildings = buildings;
            Rector = rector;
            LegalAddress = legalAddress;


        }
        public void AddEmployee(Employee employee)
        {
            if (Employees.Contains(employee))
            {
                return;
            }
            foreach (Employee emp in Employees)
            {
                if (emp.Equals(employee))
                {
                    return;
                }
            }

            Employees.Add(employee);
        }
    }
}


