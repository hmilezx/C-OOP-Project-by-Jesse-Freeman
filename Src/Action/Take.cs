using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    public class Take : Action
    {
        private readonly House _house;

        public Take(House house)
        {
            _house = house;
        }

        public override string Name => Text.Language.Take;

        public override void Execute(string[] args)
        {
            if (args.Length == 1)
            {
                Console.WriteLine(Text.Language.NotTaken);
                return;
            }

            var inventory = _house.CurrentRoom;
            
            var itemName = args[1].ToLower();

            if (inventory.Contains(itemName))
            {
                var item = inventory.Take(itemName);

                if (item.CanTake)
                {
                    _house.Player.Add(item);

                    Console.WriteLine(Text.Language.TookDescripton, item.Name);
                }

                else
                {
                    Console.WriteLine(Text.Language.CantTakeDescription, itemName);
                }

                return;
            }
            Console.WriteLine(Text.Language.TakeError);
        }
    }
}
