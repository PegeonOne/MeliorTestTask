using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankController
{
    public int Count;
    const int RedArcherPrice = 1000;
    const int GreenArcherPrice = 2000;
    const int OrangeArcherPrice = 3000;
    enum ArcherType { Red, Green, Orange}
    public BankController(int _startCount)
    {
        Count = _startCount;
    }
    void AddCoins(int _amount)
    {
        Count += _amount;
    }
    void RemoveCoins(int _amount)
    {
        Count -= _amount;
        if (Count < 0) Count = 0;
    }

    public bool TryUpdateArchers(int _currentArchersCount, int _archersType)
    {
        if(_archersType == (int)ArcherType.Red)
        {
            int amount = _currentArchersCount * GreenArcherPrice;
            if(amount < Count)
            {
                RemoveCoins(amount);
                return true;
            }
        }
        if(_archersType == (int)ArcherType.Green)
        {
            int amount = _currentArchersCount * OrangeArcherPrice;
            if (amount < Count)
            {
                RemoveCoins(amount);
                return true;
            }
        }
        else
        {
            return false;
        }
        return false;
    }
    public bool TryBuyArcher(int _currentArchersCount)
    {
        if(_currentArchersCount <= 3)
        {
            if(Count >= RedArcherPrice)
            {
                RemoveCoins(RedArcherPrice);
                return true;
            }
        }
        return false;
    }
}
