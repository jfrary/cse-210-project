using System;

public class Rouge : Character
{
private int _sneakAttack;
private bool _isStealthed;


public Rouge(int SneakAttack, bool IsStealthed) : base(name, hp, inventory)
    {
      _sneakAttack = Rolldice * 2;
      _isStealthed = IsStealthed;
    }

public bool IsStealthed()
    {
        return _isStealthed;
    }
public override void Attack()
    {
        int dmg = RollDice();
        if (_isStealthed)
        {
            dmg += _sneakAttack;
            _isStealthed = false;
        }
        return dmg;
    }
public  override bool IsDead(int hp)
    {
        if (hp <= 0 )
        {
            return true;
            }
        else
        {
            return false;
        }
    }   

public override void DisplayCharacter()
    {
        Console.WriteLine($"Name: {_name},Health: {_hp}, Inventory: {_inventory}");
    }
    
}