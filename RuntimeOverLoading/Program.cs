// See https://aka.ms/new-console-template for more information

using RuntimeOverLoading;

Console.WriteLine("Hello, World!");


var players = new List<Player>
{
    new Hero(),
    new Elf(),
    new Wizard()
};


foreach (var player in players)
{
    player.Draw();
}


var drawer = new Drawer();

foreach (var player in players)
{
    _ = player switch
    {
        Elf elf => drawer.Draw(elf),
        Hero hero => drawer.Draw(hero),
        Wizard wizard => drawer.Draw(wizard),
        _ => throw new NotImplementedException()
    };
}