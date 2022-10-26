<<<<<<< HEAD
﻿
using Aula03;

var person = new Person(33, "Flavio");

var manager = new Manager(47, "Pacheco");
=======
﻿using Aula03;

Person person = new Person(33, "Flavio");

Manager manager = new Manager(47, "Pacheco");
>>>>>>> 30e0b2fd275b1ac54ab836c9cb6795cadaeb9471

Console.WriteLine(person.GetPersonDetails());
Console.WriteLine(manager.GetPersonDetails());

<<<<<<< HEAD
manager.Execute("Execute ok");
=======
Console.WriteLine(manager.GetString());

manager.Execute("some string");
>>>>>>> 30e0b2fd275b1ac54ab836c9cb6795cadaeb9471
