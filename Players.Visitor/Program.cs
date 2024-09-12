// See https://aka.ms/new-console-template for more information

using Players.Visitor;

Console.WriteLine("Hello, World!");

var players = new List<Player>
{
    new Hero(),
    new Elf(),
    new Wizard()
};

var drawer = new Drawer();
var printer = new Printer();

foreach (var player in players)
{
    player.Visit(drawer);

    player.Visit(printer);
}