using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure.Src.Action
{
    public sealed class Actions
    {
        private static Actions _instance;

        public static Actions Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new Actions();
                return _instance;
            }


        }

        private readonly Dictionary<string, Action> _registeredActions = new();
        private Actions() 
        {
           // prevents creating an instance of actions outside the class itself as it is a private constructor 
        }
    }
}