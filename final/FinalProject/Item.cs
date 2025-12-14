using System;

public class Item
{
    
private string _name;
private float _weight;
private int _value;

public Item(string name, float weight, int value)
    {
        _name = name;
        _weight = weight;
        _value = value;
    }

public abstract string ItemName();

public abstract string ItemWeight();

public abstract string ItemValue();

public abstract void DisplayStats();

}

