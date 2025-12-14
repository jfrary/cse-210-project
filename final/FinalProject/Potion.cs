using System;

public class Item
{
    
private int _heal;


public Item(string name, int heal, float weight, int value) : base(name, weight, value)
    {
        _heal = heal;
    }


public string ItemName()
    {
        return _name;
    }
public string ItemWeight()
    {
        return _weight;
    }
public string ItemValue()
    {
        return _value;

}

public override void DisplayStats()
    {
        Console.WriteLine($"{_name}, {_heal}, {_weight}, {_value}");
    }
}


    