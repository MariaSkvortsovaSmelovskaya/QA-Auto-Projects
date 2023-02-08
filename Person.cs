

namespace Sort
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Person prsn)
            {
                return LastName == prsn.LastName;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode();
        }
    }
}
