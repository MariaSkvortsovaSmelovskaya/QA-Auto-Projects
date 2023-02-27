

namespace Exeptions
{
    public class Person
    {
        public const int MaxLength = 15;
        private string _firstName;
        private string _lastName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                ValidLength(value, LastName == null ? "" : LastName);

                _firstName = value;

            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                ValidLength(FirstName == null ? "" : FirstName, value);

                _lastName = value;
            }
        }

        public Person(string firstName, string lastName)
        {
            if (firstName == null || lastName == null)
            {
                throw new ArgumentException("Error_1_empty field");
            }


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

        public void ValidLength(string firstName, string lastName)
        {

            if ((firstName.Length + lastName.Length) > MaxLength)
            {
                throw new ArgumentException("Such length is impossible to input");
            }

        }

        public int LengthCheck()
        {
            return (FirstName.Length + LastName.Length);
        }

        public override string ToString() 
        { 
            return FirstName + " " + LastName;
        }
    }

}

    

