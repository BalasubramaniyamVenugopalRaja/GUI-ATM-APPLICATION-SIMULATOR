using System;
using System.Windows;

namespace ATMApplication
{
    public partial class MainWindow : Window
    {
        private AtmApplication atmApp;
        private Account currentAccount;

        public MainWindow()
        {
            InitializeComponent();
            atmApp = new AtmApplication();
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int accountNumber = int.Parse(NewAccountNumberTextBox.Text);
                double initialBalance = double.Parse(InitialBalanceTextBox.Text);
                double interestRate = double.Parse(InterestRateTextBox.Text);
                string accountHolderName = AccountHolderNameTextBox.Text;

                atmApp.CreateAccount(accountNumber, initialBalance, interestRate, accountHolderName);
                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}");
            }
        }

        private void SelectAccountButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int accountNumber = int.Parse(AccountNumberTextBox.Text);
                currentAccount = atmApp.SelectAccount(accountNumber);
                if (currentAccount != null)
                {
                    MessageBox.Show($"Account selected: {currentAccount.AccountHolderName}");
                }
                else
                {
                    MessageBox.Show("Account not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting account: {ex.Message}");
            }
        }

        private void DepositCashButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentAccount != null)
            {
                try
                {
                    double amount = double.Parse(AmountTextBox.Text);
                    currentAccount.Deposit(amount);
                    MessageBox.Show("Deposit successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during deposit: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No account selected.");
            }
        }

        private void WithdrawCashButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentAccount != null)
            {
                try
                {
                    double amount = double.Parse(AmountTextBox.Text);
                    if (currentAccount.Withdraw(amount))
                    {
                        MessageBox.Show("Withdrawal successful!");
                    }
                    else
                    {
                        MessageBox.Show("Insufficient funds.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during withdrawal: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No account selected.");
            }
        }

        private void CheckBalanceButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentAccount != null)
            {
                MessageBox.Show($"Current Balance: {currentAccount.Balance}");
            }
            else
            {
                MessageBox.Show("No account selected.");
            }
        }

        private void DisplayTransactionsButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentAccount != null)
            {
                string transactions = string.Join("\n", currentAccount.Transactions);
                MessageBox.Show($"Transactions:\n{transactions}");
            }
            else
            {
                MessageBox.Show("No account selected.");
            }
        }

        private void ExitCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ExitAdminButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

