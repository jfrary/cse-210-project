using System;

public class Character
{
private string _name;
private int _hp;
private int _inventory;

public Character(string name, int hp, string inventory)
    {
        _name = name;
        _hp = hp;
        _inventory = inventory;
    }

public string Name()
    {
        return _name;
    }
public string HP()
    {
        return _hp;
    }
public string Inventory()
    {
        return _inventory;
    }
    
public abstract void Cast();
public abstract void  Attack();
public abstract bool IsDead();
public abstract void DisplayCharacter();
public abstract int RollDice();
}