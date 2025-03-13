using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    public class Inventory : IInventory
    {
        private List<Item> Items { get; } = new List<Item>(); // initialize properly 
        public int Total => Items.Count; // Displays the number of items in the Items list everytime it is called

        public string[] Inventoryist => Items.Select(i  => i.Name).ToArray(); // extracts name property from each item and then adds it into string array InventoryList 

        public void Add(Item item) // Never forget to put void as it does not return anything and is just a function
        {
            Items.Add(item); // Adds the item argument into the Items list and never forget to write the argument in the parentheses 
        }

        public void Remove(Item item)
        {
            Items.Remove(item); // Removes the item being passed into the argument from the Items list 
        }

        public Item? Find(string itemname) // Method to Find the item name from the list so you create a foreachloop after
        {
            foreach (var item in Items)
            {
                if (item?.Name == itemname) // check if it is there 
                {
                    return item; // return item in item argument if it is there in the list 
                }
            }
            return null; // return null in case it is not there so it doesnt call a property thats not there
        }

        public Item? Find(string itemname, bool remove) // Overloads previous method so in case you want to remove
        {
            var item = Find(itemname);

            if (item != null && remove) // checks if item is there and wants to be removed 
            {
                Remove(item);
            }
            return item;
        }

        public bool Contains(string itemname) // method to check if the item is there so we will call the find method
        {
            return Find(itemname) != null;
        }

        public Item? Take(string itemname) // to check if the item name if the remove flag is true
        {
            return Find(itemname, true);
        }

        public void Use(string itemname, string source)
        {
            var item = Find(itemname);

            if (item != null)
            {
                item.Use(source);
                if (item.SingleUSe) // checks if it is only used once as referenced in the item.cs
                    Remove(item);
                return;
            }

            Console.WriteLine(Text.Language.NoItem, itemname);
        }
    }
}
