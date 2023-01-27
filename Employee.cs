

using System.Xml.Linq;

namespace LegalStructure;

public class Employee : Person
{
    private int _taxId;
    
    public string UniversityEmployeePosition { get; set; }

    public int TaxId
    {
        get
        {
            return _taxId;
        }
        set
        {
            if (value > 0)
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
        return false;
        
    }

    public override int GetHashCode()
    { 
        return TaxId.GetHashCode(); 
    }
}