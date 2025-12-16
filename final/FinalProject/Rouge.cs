using System;

public class Rouge : Character
{
// private int _sneakAttack;
private bool _isStealthed;


public Rouge(string name, int hp, int inventory,  bool IsStealthed) : base(name, hp, inventory)
    {
    //   _sneakAttack = DiceRollers.RollDice() * 2;
      _isStealthed = IsStealthed;
    }

public bool IsStealthed()
    {
        return _isStealthed;
    }
// public override int Attack()
//     {
//         int dmg = DiceRoller.Roll(3, 6);
//         if (_isStealthed)
//         {
//             dmg += _sneakAttack;
//             _isStealthed = false;
//         }
//         return dmg;
    
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

public override void DisplayCharacter()
    {
        Console.WriteLine($"Name: {_name},Health: {_hp}, Inventory: {_inventory}");
    }
    
}