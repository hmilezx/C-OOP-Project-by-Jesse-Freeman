namespace oop_adventure;

public class Player : Character, IInventory
{
    private readonly IInventory _inventory; // references the inventory class to the player itself 
    public Player(string name) : base(name)
    {
        _inventory = new Inventory(); // inside cinstructor make a new reference to new inventory class _inventory is the instance 
    }

    public int Total => _inventory.Total;

    public string[] Inventoryist => _inventory.Inventoryist;

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
