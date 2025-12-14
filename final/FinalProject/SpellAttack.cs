using System;

class SpellAttack : CombatAction
{
private string _spell;

private DiceRollers _diceAttackRoll;
private DiceRollers _diceDamageRoll;

public SpellAttack(string spell, DiceRollers diceAttackRoll, DiceRollers diceDamageRoll)
    {
        _spell = spell;
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