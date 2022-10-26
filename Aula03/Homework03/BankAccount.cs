using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    internal class BankAccount
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public BankAccount(int number, string name, double balance)
        {
            Number = number;
            Name = name;
            Balance = balance;
        }

        public virtual string GetAccountDetails()
        {
            return 
                $@"Número da Conta: {Number}
Dono da Conta: {Name}
Saldo Atual: {Balance}
";
        }

    }

    
}
