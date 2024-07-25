public class AtmApplication
{
    private Bank bank;

    public AtmApplication()
    {
        bank = new Bank();
    }

    public void CreateAccount(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
    {
        var account = new Account(accountNumber, initialBalance, interestRate, accountHolderName);
        bank.AddAccount(account);
    }

    public Account SelectAccount(int accountNumber)
    {
        return bank.RetrieveAccount(accountNumber);
    }

    public Bank GetBank()
    {
        return bank;
    }
}
