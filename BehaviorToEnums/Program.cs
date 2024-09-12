// See https://aka.ms/new-console-template for more information

using BehaviorToEnums;

Console.WriteLine("Hello, World!");


var volvo = new Car
{
    Plate = "ABC123",
    Status = Status.Inactive
};

var exicutor = new StartEngion();

volvo.Execute(exicutor);


Console.WriteLine("end");

