using System;

public abstract class Item
{
    
protected string _name;
protected int _weight;
protected int _value;

public Item(string name, int weight, int value)
    {
        _name = name;
        _weight = weight;
        _value = value;
    }

public abstract string ItemName();

public abstract int ItemWeight();

public abstract int ItemValue();

public abstract void DisplayStats();

}

