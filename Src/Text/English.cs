namespace oop_adventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, What is yout name?";
        DefaultName = "Miles";
        Welcome = "Welcome {0} to your OOP Adventure";
        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = "You are in a {0} room with doors to the {1}";
        ActionError = "You cannot do that";
        Go = "Go";
        GoError = "You cannot go that way";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You Entered {0}";
        RoomOld = "You returned to {0}";
        And = "And";
        Comma = ",";
        Space = " ";
        RoomDescriptions = new List<string>
        {
            "Normal",
            "Cold",
            "Warm",
            "dark",
            "bright",
            "scary",
            "strange",
        };
        NoItem = "You do not have {0}. ";
        Backpack = "Backpack";
        BackpackError = "No items in the backpack";
        BackpackDescription = "your backpack contains {0}";
    }
}