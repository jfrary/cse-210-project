using System;

public abstract class Potion : Item
{
    
private int _heal;


public Potion(string name, int heal, int weight, int value) : base(name, weight, value)
    {
        _heal = heal;
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
        Console.WriteLine($"{ItemName}, {_heal}, {ItemWeight}, {ItemValue}");
    }
}


    