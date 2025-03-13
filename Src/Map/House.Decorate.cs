using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure;


    public partial class House
    {
        public void DecorateRooms() // void means it does not return anything ie. it is just gonna do an operation or function with no return value 
        {
            foreach(var room in Rooms)
            {
            var roomDescription = Text.Language.RoomDescriptions[0];

            if(Text.Language.RoomDescriptions.Count > 1 && _rnd.Next(0, 2) == 1) // 0,2 generates beween those two numbers and if 1 then it is true
            { 
                roomDescription = Text.Language.RoomDescriptions[_rnd.Next(1, Text.Language.RoomDescriptions.Count)];   // rounds off room description bewtween 1 and length of room description count 
                Text.Language.RoomDescriptions.Remove(roomDescription);
            }

            room.Description = String.Format(Text.Language.DefaultRoomDescription, roomDescription, "{0}"); 
            }
        }


    public void PopulateRooms(List<Item> items)
    {
        var i = 0;

        while (i != items.Count)
        {
            var room = Rooms[_rnd.Next(0, Rooms.Length)];

            if(room.Total == 0)
            {
                room.Add(items[i]);
                i++;
            }
        }
    }
}

