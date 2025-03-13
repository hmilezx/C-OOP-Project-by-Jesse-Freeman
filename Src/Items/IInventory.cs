namespace oop_adventure
{
    public interface IInventory
    {
        int Total { get; }
        public string[] Inventoryist { get; }
        void Add(Item item);
        bool Contains(string itemname);
        Item? Find(string itemname);
        Item? Find(string itemname, bool remove);
        void Remove(Item item);
        Item? Take(string itemname);
        void Use(string itemname, string source);
    }
}