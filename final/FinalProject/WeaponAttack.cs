using System;

class WeaponAttack : CombatAction
{
private string _weapon;
private DiceRollers _diceAttackRoll;
private DiceRollers _diceDamageRoll;

public WeaponAttack(string weapon, DiceRollers diceAttackRoll, int diceDamageRoll)
    {
        _weapon = weapon;
        _diceAttackRoll = diceAttackRoll;
        _diceDamageRoll = diceDamageRoll;
        
    }
public override void AttackThem()
    {
        int DieResult = _diceAttackRoll.Roll();
        return DieResult;
    }
public override void Damage()
    {
        int DieResult = _diceDamageRoll.Roll();
        return DieResult;
    }
    
}