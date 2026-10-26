// Custom exception 1
public class InsufficientFundsException : Exception
{
    public decimal Balance { get; }
    public decimal RequestedAmount { get; }

    public InsufficientFundsException(decimal balance, decimal requestedAmount)
        : base("Insufficient funds for withdrawal."){
        Balance = balance;
        RequestedAmount = requestedAmount;
    }
}

// Custom exception 2
public class InvalidAmountException : Exception
{
    public InvalidAmountException(string message): base(message)
    {

    }
}

// Bank account class
public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)throw new InvalidAmountException("Initial balance cannot be negative.");
        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new InvalidAmountException("Withdrawal amount must be positive.");
        }
        if (amount > Balance)
        {
            throw new InsufficientFundsException(Balance, amount);
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawal successful: {amount}");
    }
}

// Main program
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000);

        decimal[] withdrawals = { 200, 1500, -50, 300 };

        foreach (decimal amount in withdrawals)
        {
            try
            {
                Console.WriteLine($"\nWithdrawing: {amount}");
                account.Withdraw(amount);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine($"Available balance: {e.Balance}");
                Console.WriteLine($"Requested amount: {e.RequestedAmount}");
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
            finally
            {
                Console.WriteLine($"Current balance: {account.Balance}");
            }
        }
    }
}
