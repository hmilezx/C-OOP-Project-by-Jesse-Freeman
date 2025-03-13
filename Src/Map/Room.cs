using System.Text;
namespace oop_adventure;



public class Room : IInventory
{
    
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;
    private readonly IInventory _inventory = new Inventory();
    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
        {Directions.North, -1 },
        {Directions.East, -1 },
        {Directions.South, -1 },
        {Directions.West, -1 },
        {Directions.None, -1 },
    };

    public bool Visited { get; set; }

    public int Total => _inventory.Total;

    public string[] Inventoryist => _inventory.Inventoryist;

    public override string ToString()
    {
        var sb = new StringBuilder(); // Converts the string to a string builder so you can manipulate strings without instatinating them 

        if (Visited)
            sb.Append(string.Format(Text.Language.RoomOld, Name)); // add Name into the RoomOld String in replace of the token 
        var names = Enum.GetNames(typeof(Directions)); //converts the directions into a string 

        var directions = (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] > -1 select p).ToArray(); // confusing 

        var description = string.Format(Description, Text.Language.JoinedWordList(directions, Text.Language.And)); // Joins both the description with the directions 

        sb.Append(description); // adds description to the sb builder 

        return sb.ToString(); //converts the string builder back into a regular string 
    }

    public void Add(Item item)
    {
        _inventory.Add(item);
    }

    public bool Contains(string itemname)
    {
        return _inventory.Contains(itemname);
    }

    public Item? Find(string itemname)
    {
        return _inventory.Find(itemname);
    }

    public Item? Find(string itemname, bool remove)
    {
        return _inventory.Find(itemname, remove);
    }

    public void Remove(Item item)
    {
        _inventory.Remove(item);
    }

    public Item? Take(string itemname)
    {
        return _inventory.Take(itemname);
    }

    public void Use(string itemname, string source)
    {
        _inventory.Use(itemname, source);
    }
}


