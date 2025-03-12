using System.Text;
namespace oop_adventure;



public class Room
{
    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;
    public Dictionary<Directions, int> Neighbors { get; set; } = new()
    {
        {Directions.North, -1 },
        {Directions.East, -1 },
        {Directions.South, -1 },
        {Directions.West, -1 },
        {Directions.None, -1 },
    };

    public bool Visited { get; set; }

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

}


