namespace oop_adventure.Src.Characters;


public abstract class Character
{
    public string Name { get; set; }
    public Character(string name)
    {
        Name = name;
    }
}

