using oop_adventure;





Text.LoadLanguage(new English());
//Text.LoadLanguage(new Filipino());


Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();

if (name == String.Empty)

    name = Text.Language.DefaultName;

var player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);


Actions.Instance.Register(new Go(house));
