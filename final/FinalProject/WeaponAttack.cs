using System;

class WeaponAttack : CombatAction
{
private string _weapon;
private DiceRollers _diceAttackRoll;
private DiceRollers _diceDamageRoll;

public WeaponAttack(string weapon, DiceRollers diceAttackRoll, DiceRollers diceDamageRoll)
    {
        _weapon = weapon;
        _diceAttackRoll = diceAttackRoll;
        _diceDamageRoll = diceDamageRoll;
        
    }
public override int AttackThem()
    {
        int DieResult = _diceAttackRoll.RollDice();
        return DieResult;
    }
public override int Damage()
    {
        int DieResult = _diceDamageRoll.RollDice();
        return DieResult;
    }
    
}