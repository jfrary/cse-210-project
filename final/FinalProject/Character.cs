using System;

public abstract class Character
{
protected string _name;
protected int _hp;
protected int _inventory;

public Character(string name, int hp, int inventory)
    {
        _name = name;
        _hp = hp;
        _inventory = inventory;
    }

public string Name()
    {
        return _name;
    }
public int HP()
    {
        return _hp;
    }
public int Inventory()
    {
        return _inventory;
    }

//public abstract int Cast();
//public abstract int  Attack();
public abstract bool IsDead();
public abstract void DisplayCharacter();
// public abstract int RollDice();
}