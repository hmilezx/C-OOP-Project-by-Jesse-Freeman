using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    public class Chest : Item, IInventory
    {
        private readonly House _house;
        private readonly IInventory _inventory = new Inventory();

        public override string Name => Text.Language.Chest; // overrides Name property in Item 

        public bool Locked => true;

        public Chest(Item?[] items, House house) // constructor
        {
            CanTake = false;
            _house = house;

            foreach (var item in items)
            {
                Add(item);
            }
        }

        public override void Use(string source)
        {
            if (source == Text.Language.Key)
            {
                var items = Inventoryist;

                if (Locked)
                    Console.WriteLine(Text.Language.UnlockChest);
                if (items.Length == 0)
                {
                    Console.WriteLine(Text.Language.ChestEmpty);
                }
                else
                {
                    Console.Write(string.Format(Text.Language.ChestFound, Text.Language.JoinedWordList(items, Text.Language.And)));

                    foreach (var itemname in items)
                    {
                        var item = Take(itemname);
                        _house.Player.Add(item);
                    }
                }
            }
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
}
