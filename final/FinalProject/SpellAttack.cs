using System;

class SpellAttack : CombatAction
{
private string _spell;

private DiceRollers _diceAttackRoll;
private DiceRollers _diceDamageRoll;

public WeaponAttack(string spell, DiceRollers diceAttackRoll, int diceDamageRoll)
    {
        _spell = spell;
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