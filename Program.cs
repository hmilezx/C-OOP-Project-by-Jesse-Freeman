using oop_adventure;
using oop_adventure.Src.Characters;
using oop_adventure.Src.Text;

//Text.LoadLanguage(new English());
Text.LoadLanguage(new Filipino());


Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();

if (name == String.Empty)

    name = Text.Language.DefaultName;

var player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name);