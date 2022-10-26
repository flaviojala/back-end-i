
using Homework03;

var account = new BankAccount(01, "Flavio Oliveira", 1000.00);
var savings = new SavingAccount(02, "Random Name", 2000.00, 500.50);

Console.WriteLine(account.GetAccountDetails());

Console.WriteLine(savings.GetAccountDetails());
