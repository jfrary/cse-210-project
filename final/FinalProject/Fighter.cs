using System;

class Fighter : Character
{
private int _armorClass;

public Fighter(string name, int hp , int armorClass, int inventory) : base(name, hp, inventory)
    {
        _armorClass = armorClass;
    }

public int ArmorClass()
    {
        return _armorClass;
    }
public override void DisplayCharacter()
    {
        Console.WriteLine($"Name: {_name},Health: {_hp},Armor Class: {_armorClass}, Inventory: {_inventory}");
    }
// public override int Attack()
//     {
//         int dmg = DiceRoller.Roll(2, 6);

//         return dmg;
//     }
public  override bool IsDead()
    {
        return _hp <= 0;
        // if (hp <= 0 )
        // {
        //     return true;
        //     }
        // else
        // {
        //     return false;
        // }
    }     
}