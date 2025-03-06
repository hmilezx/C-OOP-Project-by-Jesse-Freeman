using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure.Src.Action
{
    public abstract class Action
    {
        public virtual string Name => "";
        public virtual void Execute(string[] args)
        {
            throw new Exception("Nothing to execute");
        }
    }
}
