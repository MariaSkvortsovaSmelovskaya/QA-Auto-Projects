

namespace Sort
{
    public class Room
    {
        private const int Max_Placement_Number = 300;
        private int _placement;

        public string RoomsName { get; set; }


        public int Placement
        {
            get
            {
                return _placement;
            }
            set
            {
                if (value > 0 && value < Max_Placement_Number)
                {
                    _placement = value;
                }
            }
        }
        public Room(string roomsName, int placement)
        {

            RoomsName = roomsName;
            Placement = placement;

        }

        public override bool Equals(object? obj)
        {
            if (obj is Room rms)
            {
                return RoomsName == rms.RoomsName && Placement == rms.Placement;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return RoomsName.GetHashCode() + Placement;
        }

       
    }
}

