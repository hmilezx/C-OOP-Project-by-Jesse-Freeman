using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure
{
    public abstract class Item // when you make an abstract class which is basically a base class
    {
        public virtual string ItemName { get; set; } // if the item is gonnna be overriden then write virtual to allow it 

        public bool SingleUSe { get; set; } // implemented for items that are single use ie. if it is used then true or false 

        public bool CanTake { get; set; }   // what to do when player picks up an item 

        public virtual void Use(string source) // source is what is usaing the item, method will be overriden in children classes
        {
            throw new NotImplementedException(); // implement if extended as it is only for base 
        }
    }
}
