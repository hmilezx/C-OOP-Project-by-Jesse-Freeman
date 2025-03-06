using oop_adventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, What is yout name?";
        DefaultName = "Miles";
        Welcome = "Welcome {0} to your OOP Adventure";
        DefaultRoomName = "Room {0} ({1},{2})";
        DefaultRoomDescription = "You are in a room with doors to the {0}";
    }
}