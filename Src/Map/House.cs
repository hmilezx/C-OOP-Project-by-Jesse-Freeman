using oop_adventure.Src.Characters;

namespace oop_adventure.Src.Map;

public partial class House
{
    public Player Player { get; }
    private readonly Random _rnd = new Random(1234);

    public House(Player player)
    {
        Player = player;
    }

}