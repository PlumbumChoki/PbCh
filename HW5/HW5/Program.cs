Bank bank = new Bank();

for (int i = 0; i < 6; i++)
{
    Thread myThread = new Thread(bank.AddCash);
    myThread.Name = $"Поток {i}";
    myThread.Start(10000);
}

for (int i = 0; i < 2; i++)
{
    Thread myThread = new Thread(bank.GetCash);
    myThread.Name = $"Поток {i}";
    myThread.Start(2000);
}


public class Bank()
{
    
    Mutex mutex = new Mutex();

    int i;

    public double myMoney { get; set; } = 10_000_000;


    public override string ToString()
    {
        return $"Текущий баланс равен {myMoney}";
    }

   

    public void GetCash(object? money)
    {
        lock (this)
        {
            if (money is double currentMoney)
            {
                if (myMoney - currentMoney >= 0)
                {
                    myMoney -= currentMoney;
                }
            }
        }
    }

    public void AddCash(object? money)
    {
        mutex.WaitOne();

        if (money is double currentMoney)
        {
            myMoney += currentMoney;
        }

        mutex.ReleaseMutex();
    }
}