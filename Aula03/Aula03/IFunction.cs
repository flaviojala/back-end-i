using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    internal interface IFunction
    {
        public int MyProperty { get; set; }

        void Execute(string something);
    }
}
