using Lesson_11;

Console.WriteLine("****Fun with Static Data*****\n");
SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);

//выести текущую процентную ставку
Console.WriteLine("Interest Rate is:{0}", SavingsAccount.GetInterestRate());

//создаем новій обьект
SavingsAccount s3 = new SavingsAccount(10000.75);
Console.WriteLine("Interest Rate is:{0}", SavingsAccount.GetInterestRate());

Console.ReadLine();