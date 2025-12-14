using System;

public class Armor : Item
{
    
private string _armorClass;


public Armor(string name, int armorClass, float weight, int value) : base(name, weight, value)
    {
        _armorClass = armorClass;
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
        Console.WriteLine($"{_name}, {_armorClass}, {_weight}, {_value}");
    }

}