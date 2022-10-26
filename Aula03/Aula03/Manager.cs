using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    internal class Manager : Person, IFunction
    {
        public Manager(int age, string name) : base(age, name)
        {
<<<<<<< HEAD

=======
>>>>>>> 30e0b2fd275b1ac54ab836c9cb6795cadaeb9471
        }

        public int MyProperty { get; set; }

        public void Execute(string something)
        {
            Console.WriteLine(something);
        }

        public override string GetPersonDetails()
        {
            return $"Nome: {Name}";
        }
<<<<<<< HEAD
=======

        public string GetString()
        {
            return "String Getted";
        }
>>>>>>> 30e0b2fd275b1ac54ab836c9cb6795cadaeb9471
    }
}
