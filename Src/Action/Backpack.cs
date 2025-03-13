using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    internal class Backpack : Action
    {
        private readonly IInventory _inventory;

        public Backpack(IInventory inventory) // constructor 
        {
            _inventory = inventory;
        }

        public override string Name => Text.Language.Backpack;

        public override void Execute(string[] args)
        {
            var items = _inventory.Inventoryist;     // Its referencing to the inventory list since it needs a string of arrays 

            if (items.Length == 0)
            {
               Console.WriteLine(Text.Language.BackpackError);
                return;
            }

            var list = Text.Language.JoinedWordList(items, Text.Language.And);

            Console.WriteLine(Text.Language.BackpackDescription, list);
        }
    }
}
