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
    }
}
