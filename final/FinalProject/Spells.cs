using System;

public abstract class Spells
{
    private string _name;
    private int _damage;
    private int _range;
    private int _spellSlotUse;

    public Spells(string name, int damage, int range, int spellSlotUse)
    {
        _name = name;
        _damage = damage;
        _range = range;
        _spellSlotUse = spellSlotUse;
    }

    public abstract string Spell();
    public abstract int Dmg();
    public abstract int Range();
    public abstract int SpellSlotMinus();
}