using Aula03;

Person person = new Person(33, "Flavio");

Manager manager = new Manager(47, "Pacheco");

Console.WriteLine(person.GetPersonDetails());
Console.WriteLine(manager.GetPersonDetails());

Console.WriteLine(manager.GetString());

manager.Execute("some string");
