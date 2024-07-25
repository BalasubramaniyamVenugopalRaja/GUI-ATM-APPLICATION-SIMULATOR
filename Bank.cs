﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Bank
{
    private List<Account> accounts;

    public Bank()
    {
        accounts = new List<Account>();
        for (int i = 100; i < 110; i++)
        {
            accounts.Add(new Account(i, 100, 0.03, $"User{i}"));
        }
    }

    public Account RetrieveAccount(int accountNumber)
    {
        return accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public List<Account> GetAccounts()
    {
        return accounts;
    }
}

