using System;

namespace Models
{
    interface IAccount
    {
        string Debit(int amount);
        string Credit(int amount);
    }
}
