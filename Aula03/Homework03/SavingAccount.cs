using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    internal class SavingAccount : BankAccount
    {
        public double Savings { get; set; }
        public SavingAccount(int , string name, double balance, double savings) : base(number, name, balance)
        {
            Savings = savings;
            Balance = balance - savings;
        }

        public override string GetAccountDetails()
        {
            return
                $@"Número da Conta: {Number}
Dono da Conta: {Name}
Saldo em Conta Corrente: {Balance}
Saldo em Conta Poupança: {Savings}
Total: {Balance+Savings}
";
        }
    }
}
