using System;

public class Weapon : Item
{
    
private int _range;
private int _damage;

public Weapon(string name, int weight, int value, int range, int damage) : base(name, weight, value)
    {
        _range = range;
        _damage = damage;
    }




public override string ItemName()
    {
        return _name;
    }
public override int ItemWeight()
    {
        return _weight;
    }
public override int ItemValue()
    {
        return _value;
    }

public override void DisplayStats()
    {
        Console.WriteLine($"{_name}, {_damage}, {_range}, {_weight}, {_value}");
    }
}



