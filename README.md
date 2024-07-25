# ATM Application GUI

## PROG8051: Assignment 3 - ATM Application GUI

### Summary

This is a full ATM GUI application developed using C# and WPF in .NET Framework. It simulates the functionality of an ATM, allowing the user to create accounts, select accounts, withdraw and deposit money, check balances, and display a list of transactions.

### Features

- **Customer Portal**
  - Select Account
  - Deposit Cash
  - Withdraw Cash
  - Check Balance
  - Display Transactions
  - Exit

- **Admin Portal**
  - Create Account
  - Exit

### Project Structure

- **Account Class**: Handles the account details and operations like deposit, withdrawal, balance checking, and transaction logging.
- **Bank Class**: Manages a list of accounts and provides methods to retrieve account details.
- **AtmApplication Class**: Implements the interaction with the user, displays menus, takes input from the user, and displays the output.
- **MainWindow**: Provides the GUI for the application using WPF.

A video demonstration of the application can be found [here](https://youtu.be/ytd9LIKnE-I).

### How to Run

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/BalasubramaniyamVenugopalRaja/ATMApplicationGUI.git
