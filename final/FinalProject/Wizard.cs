using System;

class Wizard : Character
{

private int _spellSlots;
private string _knownSpells;

public Wizard(string name, int hp , int spellSlots, string knownSpells, int inventory) : base(name, hp, inventory)
    {
        _spellSlots = spellSlots;
        _knownSpells = knownSpells;
    }



public int SpellSlots()
    {
        return _spellSlots;
    }

public void UseSpellSlot(int amount)
    {
        _spellSlots -= amount;
        if (_spellSlots < 0)
            _spellSlots = 0;
    }
public string knownSpells()
    {
        return _knownSpells;
    }
public override void DisplayCharacter()
    {
        Console.WriteLine($"Name: {_name},Health: {_hp}, Spell Slots: {_spellSlots}, Spells: {_knownSpells}");
    }
// public override int Cast()
//     {
//         int sdmg = RollDice();
//         return sdmg;
//     }
// public override int Attack()
//     {
//         int dmg = DiceRoller.Roll(3, 6);
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