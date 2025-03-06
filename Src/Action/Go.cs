namespace oop_adventure
{
    public class Go : Action
    {
        private readonly House _house;

        public Go(House house)
        {
            _house = house;
        }

        public override void Execute(string[] args)
        {
            var currentRoom = _house.CurrentRoom;
            var dir = args[1].Substring(0, 1).ToUpper() + args[1].Substring(1).ToLower();
            if (!Enum.TryParse(dir, out Directions newDirection))
            {
                Console.WriteLine(Text.Language.GoError);
                return;
            }

            var nextRoomIndex = currentRoom.Neighbors[newDirection];

            if (nextRoomIndex == -1 || newDirection == Directions.None)
                Console.WriteLine(Text.Language.GoError);
            else
                _house.GoToRoom(nextRoomIndex);
        }
    }
}
