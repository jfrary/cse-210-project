using System;


class Fireball : Spells
{
    public Fireball() : base("Fireball", 8, 30, 1)
    {

    }

    public override string Spell()
    {
        return "Fireball";
    }
        public override int Dmg()
    {
        DiceRollers dice = new DiceRollers(3, 8, 0);
        return dice.RollDice();
    }
    
    public override int Range()
    {
        return 30;
    } 

    public override int SpellSlotMinus()
    {
        return 1;
    }
}