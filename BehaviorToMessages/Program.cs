// See https://aka.ms/new-console-template for more information

using BehaviorToMessages;
using System.Text.Json;

var options = new JsonSerializerOptions();
options.Converters.Add(new PersonConverter());
options.Converters.Add(new LocationConverter());

var json = JsonSerializer.Serialize(new EnterMessage(
    new Developer("c#", "Kim"),
    new ServerRoom(10, "Aws")
));
var json2 = JsonSerializer.Serialize(new EnterMessage(
    new Architect("Kim"),
    new ServerRoom(10, "Aws")
));


var message = JsonSerializer.Deserialize<EnterMessage>(json, options);


var person = message.Person;
var location = message.Location;

person.Visit(location);

message = JsonSerializer.Deserialize<EnterMessage>(json2, options);


person = message.Person;
location = message.Location;

person.Visit(location);
