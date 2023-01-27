
namespace LegalStructure;

public class Building
{

    private const int Max_Block_Number = 100;
    private int _block;


    public string Street { get; set; }
    public List<Room> Rooms { get; set; }

    public int Block
    {
        get
        {
            return _block;
        }
        set
        {
            if (value > 0 && value < Max_Block_Number)
            {
                _block = value;
            }
        }
    }

    public Building(string street, int block)
    {
        Street = street;
        Block = block;

    }

    public override bool Equals(object? obj)
    {
        if (obj is Building bld)
        {
            return Street == bld.Street && Block == bld.Block;
        }
        return false;
        
    }

    public override int GetHashCode()
    { 
        return Street.GetHashCode() + Block.GetHashCode();
    }
}




