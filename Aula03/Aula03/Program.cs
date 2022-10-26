
using Aula03;

var person = new Person(33, "Flavio");

var manager = new Manager(47, "Pacheco");

Console.WriteLine(person.GetPersonDetails());
Console.WriteLine(manager.GetPersonDetails());

manager.Execute("Execute ok");
